using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    internal class ElementContentValidation
    {
        private object BouncyCastle;
        private string errMsg = String.Empty;
        private string SignatureID = String.Empty;
        XmlNamespaceManager xNS;

        public ElementContentValidation() { 
        }

        internal string Validate(XDocument xml) {

            var xSignature = DocumentExtensions.ToXmlDocument(xml);
            xNS = new XmlNamespaceManager(xSignature.NameTable);

            xNS.AddNamespace("ds", Helpers.ds.NamespaceName);

            if (ValidateDSSignature(xSignature.SelectSingleNode(@"//ds:Signature", xNS))) {
                return errMsg;
            }

            XmlNode signature = xSignature.SelectSingleNode(@"//ds:Signature", xNS);
            XmlAttribute signatureId = signature.Attributes["Id"];
            SignatureID = signatureId.Value;

            if (ValidateDSSignatureValue(xSignature.SelectSingleNode(@"//ds:SignatureValue", xNS)))
            {
                return errMsg;
            }
            else if (ValidateDSSignedInfo(xSignature.SelectNodes(@"//ds:SignedInfo/ds:Reference", xNS))) 
            {
                return errMsg;
            }
            else if (ValidateDSKeyInfo(xSignature.SelectSingleNode(@"//ds:KeyInfo", xNS)))
            {
                return errMsg;
            }
            else if (ValidateDSSignatureProperties(xSignature.SelectSingleNode(@"//ds:SignatureProperties", xNS)))
            {
                return errMsg;
            }
            else if (ValidateDSManifest(xSignature.SelectNodes(@"//ds:Manifest", xNS)))
            {
                return errMsg;
            }
            else if (ValidateDSManifestReferences(xSignature.SelectNodes(@"//ds:Manifest", xNS)))
            {
                return errMsg;
            }


            return String.Empty;
        }

        // Overenie atributov ds:Signature
        private bool ValidateDSSignature(XmlNode signature) {

            var idAttr = signature.Attributes["Id"];
            if (Object.Equals(idAttr, null)) {
                errMsg = "Chyba: ds:Signature neobsahuje atribut ID!";
                return true;
            }

            var nsURI = signature.NamespaceURI;
            if (!String.IsNullOrEmpty(nsURI))
            {
                var ns = signature.GetPrefixOfNamespace(nsURI);
                if (String.IsNullOrEmpty(ns) || !ns.Equals("ds"))
                {
                    errMsg = "Chyba: ds:Signature neobsahuje specifikaciu pre Namespace 'ds'!";
                    return true;
                }
            }
            else {
                errMsg = "Chyba: ds:Signature neobsahuje specifikaciu pre Namespace!";
                return true;
            }

            return false;
        }

        private bool ValidateDSSignatureValue(XmlNode signatureValue) {

            var idAttr = signatureValue.Attributes["Id"];
            if (Object.Equals(idAttr, null))
            {
                errMsg = "Chyba: ds:SignatureValue neobsahuje atribut ID!";
                return true;
            }

            return false;
        }

        private bool ValidateDSSignedInfo(XmlNodeList signedInfoReferences) {

            bool SignedPropertiesVyskyt = true;
            bool SignaturePropertiesVyskyt = true;
            bool KeyInfoVyskyt = true;

            foreach (XmlNode reference in signedInfoReferences)
            {
                XmlAttribute type = reference.Attributes["Type"];

                if (!object.Equals(type, null))
                {
                    string typeVal = type.Value;

                    switch (typeVal)
                    {
                        case "http://uri.etsi.org/01903#SignedProperties":

                            if (SignedPropertiesVyskyt)
                            {
                                #region SignedPropertiesKontrola

                                string idCheck = "Reference" + SignatureID + "SignedProperties";
                                XmlAttribute idAttr = reference.Attributes["Id"];

                                if (!object.Equals(idAttr, null))
                                {
                                    string idAttrVal = idAttr.Value;
                                    if (!string.Equals(idAttrVal, idCheck))
                                    {
                                        errMsg = "Chyba: Referencia pre SignedProperties v ds:SignedInfo obsahuje atribut ID so zlou hodnotou!";
                                        return true;
                                    }
                                }
                                else
                                {
                                    errMsg = "Chyba: Referencia pre SignedProperties v ds:SignedInfo neobsahuje atribut ID!";
                                    return true;
                                }

                                string uriCheck = "#" + SignatureID + "SignedProperties";
                                XmlAttribute uriAttr = reference.Attributes["URI"];

                                if (!object.Equals(uriAttr, null))
                                {
                                    string uriAttrVal = uriAttr.Value;
                                    if (!string.Equals(uriAttrVal, uriCheck))
                                    {
                                        errMsg = "Chyba: Referencia pre SignedProperties v ds:SignedInfo obsahuje atribut URI so zlou hodnotou!";
                                    }
                                }
                                else
                                {
                                    errMsg = "Chyba: Referencia pre SignedProperties v ds:SignedInfo neobsahuje atribut URI!";
                                    return true;
                                }

                                SignedPropertiesVyskyt = false;

                                #endregion
                            }
                            else
                            {
                                errMsg = "Chyba: V ds:SignedInfo sa nachadza viac referencii pre SignedProperties!";
                                return true;
                            }

                            break;
                        case "http://www.w3.org/2000/09/xmldsig#Manifest":

                            #region ManifestKontrola

                            string idCheckMF = "ReferenceManifestObject";
                            XmlAttribute idAttrMF = reference.Attributes["Id"];
                            string idAttrMFVal = String.Empty;

                            if (!object.Equals(idAttrMF, null))
                            {
                                idAttrMFVal = idAttrMF.Value;
                                if (!idAttrMFVal.Contains(idCheckMF))
                                {
                                    errMsg = "Chyba: Referencia pre Manifest objekt v ds:SignedInfo obsahuje ID atribut so zlou hodnotou!";
                                    return true;
                                }
                            }
                            else
                            {
                                errMsg = "Chyba: Referencia pre Manifest objekt v ds:SignedInfo neobsahuje atribut ID!";
                                return true;
                            }

                            XmlAttribute uriAttrMF = reference.Attributes["URI"];
                            if (!object.Equals(uriAttrMF, null))
                            {
                                string uriAttrMFVal = uriAttrMF.Value;
                                if (!idAttrMFVal.Contains(uriAttrMFVal.Replace("#", "")))
                                {
                                    errMsg = "Chyba: Referencia pre Manifest objekt v ds:SignedInfo obsahuje atribut URI so zlou hodnotou!";
                                    return true;
                                }
                            }
                            else
                            {
                                errMsg = "Chyba: Referencia pre Manifest objekt v ds:SignedInfo neobsahuje atribut URI!";
                                return true;
                            }

                            #endregion

                            break;
                        case "http://www.w3.org/2000/09/xmldsig#SignatureProperties":

                            if (SignaturePropertiesVyskyt)
                            {
                                #region SignaturePropertiesKontrola

                                string idCheckSP = "Reference" + SignatureID + "SignatureProperties";
                                XmlAttribute idAttrSP = reference.Attributes["Id"];

                                if (!object.Equals(idAttrSP, null))
                                {
                                    string idAttrVal = idAttrSP.Value;
                                    if (!string.Equals(idAttrVal, idCheckSP))
                                    {
                                        errMsg = "Chyba: Referencia pre SignatureProperties v ds:SignedInfo obsahuje atribut ID so zlou hodnotou!";
                                        return true;
                                    }
                                }
                                else
                                {
                                    errMsg = "Chyba: Referencia pre SignatureProperties v ds:SignedInfo neobsahuje atribut ID!";
                                    return true;
                                }

                                string uriCheckSP = "#" + SignatureID + "SignatureProperties";
                                XmlAttribute uriAttrSP = reference.Attributes["URI"];

                                if (!object.Equals(uriAttrSP, null))
                                {
                                    string uriAttrVal = uriAttrSP.Value;
                                    if (!string.Equals(uriAttrVal, uriCheckSP))
                                    {
                                        errMsg = "Chyba: Referencia pre SignatureProperties v ds:SignedInfo obsahuje atribut URI so zlou hodnotou!";
                                    }
                                }
                                else
                                {
                                    errMsg = "Chyba: Referencia pre SignatureProperties v ds:SignedInfo neobsahuje atribut URI!";
                                    return true;
                                }

                                SignaturePropertiesVyskyt = false;
                                #endregion
                            }
                            else
                            {
                                errMsg = "Chyba: V ds:SignedInfo sa nachadza viac referencii pre SignatureProperties!";
                                return true;
                            }

                            break;
                        case "http://www.w3.org/2000/09/xmldsig#Object":

                            if (KeyInfoVyskyt)
                            {
                                #region KeyInfoKontrola

                                string idCheckKI = "Reference" + SignatureID + "KeyInfo";
                                XmlAttribute idAttrKI = reference.Attributes["Id"];

                                if (!object.Equals(idAttrKI, null))
                                {
                                    string idAttrVal = idAttrKI.Value;
                                    if (!string.Equals(idAttrVal, idCheckKI))
                                    {
                                        errMsg = "Chyba: Referencia pre KeyInfo v ds:SignedInfo obsahuje atribut ID so zlou hodnotou!";
                                        return true;
                                    }
                                }
                                else
                                {
                                    errMsg = "Chyba: Referencia pre KeyInfo v ds:SignedInfo neobsahuje atribut ID!";
                                    return true;
                                }

                                string uriCheckKI = "#" + SignatureID + "KeyInfo";
                                XmlAttribute uriAttrKI = reference.Attributes["URI"];

                                if (!object.Equals(uriAttrKI, null))
                                {
                                    string uriAttrVal = uriAttrKI.Value;
                                    if (!string.Equals(uriAttrVal, uriCheckKI))
                                    {
                                        errMsg = "Chyba: Referencia pre KeyInfo v ds:SignedInfo obsahuje atribut URI so zlou hodnotou!";
                                        return true;
                                    }
                                }
                                else
                                {
                                    errMsg = "Chyba: Referencia pre KeyInfo v ds:SignedInfo neobsahuje atribut URI!";
                                    return true;
                                }

                                KeyInfoVyskyt = false;
                                #endregion
                            }
                            else
                            {
                                errMsg = "Chyba: V ds:SignedInfo sa nachadza viac referencii pre KeyInfo!";
                                return true;
                            }

                            break;
                        default:
                            errMsg = "Chyba: Podla typu referencie sa nasla chybna referencia v ds:SignedInfo!";
                            return true;
                    }
                }
                else 
                {
                    errMsg = "Chyba: Referencia v ds:SignedInfo neobsahuje atribut Type!";
                    return true;
                }
            }

            return false;
        }

        private bool ValidateDSKeyInfo(XmlNode keyInfo) {

            XmlAttribute idAttr = keyInfo.Attributes["Id"];
            if (!object.Equals(idAttr, null))
            {
                if (keyInfo.ChildNodes.Count > 1 || keyInfo.ChildNodes.Count < 1)
                {
                    errMsg = "Chyba: Element ds:KeyInfo obsahuje viac ako jeden element ds:X509Data alebo ziadny element!";
                    return true;
                }
                else
                {
                    if (keyInfo.ChildNodes[0].Name.Equals("ds:X509Data"))
                    {
                        XmlNode x509dataNode = keyInfo.ChildNodes[0];
                        int pomVyskyt = 3;

                        string values = String.Empty;

                        foreach (XmlNode child in x509dataNode.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "ds:X509Certificate":
                                    pomVyskyt--;
                                    break;
                                case "ds:X509IssuerSerial":
                                    /*foreach (XmlNode isNode in child.ChildNodes)
                                    {
                                        values += isNode.InnerText;
                                    }*/
                                    pomVyskyt--;
                                    break;
                                case "ds:X509SubjectName":
                                    values += child.InnerText;
                                    pomVyskyt--;
                                    break;
                                default:
                                    errMsg = "Chyba: Element X509Data v ds:KeyInfo obsahuje nespravy element ";
                                    return true;
                            }
                        }

                        if (pomVyskyt != 0)
                        {
                            errMsg = "Chyba: Element X509Data v ds:KeyInfo neobsahuje niektory, z povinnych elementov";
                            return true;
                        }

                        string values64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(values));
                        XmlNode cert = x509dataNode.ChildNodes[0];
                        string certVal = cert.InnerText;
                        if (!certVal.Contains(values64))
                        {
                            errMsg = "Chyba";
                            return true;
                        }
                        // POROVNANIE HODNOT

                    }
                    else
                    {
                        errMsg = "Chyba: Element ds:KeyInfo neobsahuje spravny element!";
                        return true;
                    }
                }
            }
            else
            {
                errMsg = "Chyba: Element ds:KeyInfo neobsahuje atribut ID!";
                return true;
            }
            
            return false;
        }

        private bool ValidateDSSignatureProperties(XmlNode signatureProperties) {

            XmlAttribute idAttr = signatureProperties.Attributes["Id"];
            
            if (!object.Equals(idAttr, null))
            {
                if (signatureProperties.ChildNodes.Count == 2)
                {
                    int pomVyskyt = 4;

                    foreach (XmlNode child in signatureProperties.ChildNodes)
                    {
                        switch (child.Name)
                        {
                            case "ds:SignatureProperty":
                                pomVyskyt--;
                                break;
                            default:
                                errMsg = "Chyba: V elemente ds:SignatureProperties sa nachadza element iny ako ds:SignatureProperty";
                                return true;
                        }

                        XmlAttribute targetAttr = child.Attributes["Target"];
                        if (!object.Equals(targetAttr, null))
                        {
                            string targetAttrVal = targetAttr.Value.Replace("#","");
                            if (!string.Equals(targetAttrVal, SignatureID))
                            {
                                errMsg = "Chyba: Atribut Target v ds:SignatureProperty neodkazuje na Signature!";
                                return true;
                            }
                        }
                        else
                        {
                            errMsg = "Chyba: Element ds:SignatureProperty neobsahuje atribut Target!";
                            return true;
                        }

                        if (child.ChildNodes.Count == 1)
                        {
                            XmlNode node = child.ChildNodes[0];

                            switch (node.Name)
                            {
                                case "xzep:SignatureVersion":
                                    pomVyskyt--;
                                    break;
                                case "xzep:ProductInfos":
                                    pomVyskyt--;
                                    break;
                                default:
                                    errMsg = "Chyba: Jeden z elementov ds:SignatureProperty neobsahuje spravny podelement!";
                                    return true;
                            }
                        }
                        else
                        {
                            errMsg = "Chyba: Element ds:SignatureProperty ma nespravny pocet elementov!";
                            return true;
                        }
                    }

                    if (pomVyskyt != 0)
                    {
                        errMsg = "Chyba: Element ds:SignatureProperties neobsahuje spravne elementy!";
                        return true;
                    }
                }
                else
                {
                    errMsg = "Chyba: Element ds:SigantureProperties obsahuje menej alebo viac ako 2 elementy!";
                    return true;
                }
            }
            else
            {
                errMsg = "Chyba: Elementu ds:SignatureProperties chyba atribut ID!";
                return true;
            }

            return false;
        }

        private bool ValidateDSManifest(XmlNodeList manifestList) {

            foreach (XmlNode manifest in manifestList)
            {
                XmlAttribute idAttr = manifest.Attributes["Id"];
                if (!idAttr.Equals(null))
                {
                    if (manifest.ChildNodes.Count == 1)
                    {
                        XmlNode manifestRef = manifest.ChildNodes[0];
                        XmlAttribute typeAttr = manifestRef.Attributes["Type"];
                        if (!typeAttr.Equals(null))
                        {
                            string typeAttrVal = typeAttr.Value;
                            if (!typeAttrVal.Equals("http://www.w3.org/2000/09/xmldsig#Object"))
                            {
                                errMsg = "Chyba: Atribut Type v ds:Reference v ds:Manifest neobsahuje spravnu hodnotu!";
                                return true;
                            }

                            // TUTO POKRACOVAT
                        }
                        else
                        {
                            errMsg = "Chyba: ds:Reference v ds:Manifest neobsahuje atribut Type!";
                            return true;
                        }
                    }
                    else
                    {
                        errMsg = "Chyba: ds:Manifest obsahuje viac alebo ziadny element ds:Reference!";
                        return true;
                    }
                }
                else
                {
                    errMsg = "Chyba: ds:Manifest element neobsahuje atribut ID!";
                    return true;
                }
            }

            return false;
        }

        private bool ValidateDSManifestReferences(XmlNodeList manifestList) {

            return false;
        }
    }
}

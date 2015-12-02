using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;


namespace SIvPaVS_Podatelna
{
    internal class CoreValidation
    {

        XmlNamespaceManager xNS;
        XmlDocument xSignature;

        private object BouncyCastle;

        public CoreValidation()
        {
        }

        internal string Validate(XDocument xml)
         {
            try
            {
                xSignature = DocumentExtensions.ToXmlDocument(xml);
                xNS = new XmlNamespaceManager(xSignature.NameTable);

                xNS.AddNamespace("ds", Helpers.ds.NamespaceName);


                byte[] signatureCertificate = Convert.FromBase64String(xSignature.SelectSingleNode(@"//ds:KeyInfo/ds:X509Data/ds:X509Certificate", xNS).InnerText);
                byte[] signature = Convert.FromBase64String(xSignature.SelectSingleNode(@"//ds:SignatureValue", xNS).InnerText);
                XmlNode signedInfoN = xSignature.SelectSingleNode(@"//ds:SignedInfo", xNS);
                string signedInfoTransformAlg = xSignature.SelectSingleNode(@"//ds:SignedInfo/ds:CanonicalizationMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;
                string signedInfoSignatureAlg = xSignature.SelectSingleNode(@"//ds:SignedInfo/ds:SignatureMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;

                string result = string.Empty;
                result = Dereference(signedInfoN);
                if(!string.IsNullOrEmpty(result))
                    return "Core Validation - " + result;

                result = Canononicalize(signedInfoN);

                if (string.IsNullOrEmpty(result))
                    return string.Empty;
                else
                    return "Core Validation - " + result;



                //byte[] objSignedInfoOld = this.canonicalize(this.beforeCanonicalize(signedInfoN, true), signedInfoTransformAlg);
                //byte[] objSignedInfoNew = this.canonicalize(this.beforeCanonicalize(signedInfoN), signedInfoTransformAlg);

                //string errMsg = "";
                //bool res = this.verifySign(signatureCertificate, signature, objSignedInfoNew, signedInfoSignatureAlg, out errMsg);
                //if (!res)
                //{
                //    res = this.verifySign(signatureCertificate, signature, objSignedInfoOld, signedInfoSignatureAlg, out errMsg);
                //    if (!res)
                //    {
                //        //this.errorMessage = errMsg;
                //        return "core validation ERROR";
                //    }
                //}

                return string.Empty;
            }
            catch {
                        return "core validation ERROR";
            }
        }

        private string Canononicalize(XmlNode signedInfoN)
        {
            XmlNodeList signedInfoNodeList = signedInfoN.SelectNodes("//ds:SignedInfo", xNS);
            XmlNode signedInfoNode = signedInfoN.SelectSingleNode("//ds:SignedInfo", xNS);

            byte[] signatureCertificate = Convert.FromBase64String(signedInfoN.SelectSingleNode(@"//ds:KeyInfo/ds:X509Data/ds:X509Certificate",xNS).InnerText);
            byte[] signature = Convert.FromBase64String(signedInfoN.SelectSingleNode(@"//ds:SignatureValue", xNS).InnerText);

            XmlDsigC14NTransform t = new XmlDsigC14NTransform(false);
            XmlDocument pom = new XmlDocument();
            pom.LoadXml(signedInfoNode.OuterXml);
            t.LoadInput(pom);
            byte[] data = ((MemoryStream)t.GetOutput()).ToArray();

            string signedInfoTransformAlg = signedInfoNode.SelectSingleNode("ds:CanonicalizationMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;
            string signedInfoSignatureAlg = signedInfoNode.SelectSingleNode("ds:SignatureMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;

            return verifySign(signatureCertificate, signature, data, signedInfoSignatureAlg);
        }

        private byte[] canonicalize(XmlNode outerData, string signedInfoTransformAlg)
        {

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(outerData.InnerXml);

            var data = doc.DocumentElement;

            XmlDsigC14NTransform transform = new XmlDsigC14NTransform();
            transform.Algorithm = signedInfoTransformAlg;
            transform.LoadInput(doc);// =  data;

            var a = transform.GetOutput();
            var aa = a.ToString();

            var b = a as System.IO.Stream;

            b.Position = 0;
            byte[] buffer = new byte[b.Length];
            for (int totalBytesCopied = 0; totalBytesCopied < b.Length;)
                totalBytesCopied += b.Read(buffer, totalBytesCopied, Convert.ToInt32(b.Length) - totalBytesCopied);
            return buffer;


            //return System.Text.Encoding.UTF8.GetBytes(aa);
            //XmlDsigExcC14NTransform.
            //System.Security.Cryptography
            throw new NotImplementedException();
        }

        //private XmlElement beforeCanonicalize(XmlNode signedInfoN)
        //{

        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(signedInfoN.InnerText)));

        //    return doc.DocumentElement;

        //}

        private string Dereference(XmlNode signedInfoN, bool commments = false)
        {

            var referenceElements = signedInfoN.SelectNodes(@"//ds:Reference", xNS);
            string result = string.Empty;

            foreach (XmlNode reference in referenceElements)
            {
                result = dereferenceURI(reference);
                if (!string.IsNullOrEmpty(result))
                    return result;
                    
            }
            return result;

            //byte[] data = System.Convert.FromBase64String(signedInfoN.InnerText);
            //string base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data);

            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(signedInfoN.InnerText)));

            //return doc.DocumentElement;
            //throw new NotImplementedException();
        }

        private string dereferenceURI(XmlNode reference)
        {
            XmlAttribute uriAttr = (XmlAttribute)reference.Attributes.GetNamedItem("URI");
            string id = uriAttr.Value.Replace("#", "");

            if (id == "Signature20140325080345213SignatureProperties")
                id = id;

            XmlNode digestMethNode = reference.SelectSingleNode("ds:DigestMethod", xNS);
            XmlAttribute digestMethNode_alg = (XmlAttribute)digestMethNode.Attributes.GetNamedItem("Algorithm");
            string alg = digestMethNode_alg.Value;
            XmlNode digestValNode = reference.SelectSingleNode("ds:DigestValue", xNS);
            string digestValue = digestValNode.InnerText;

            //ak ide o manifest -> kanonikalizacia a overenie odtlacku
            if (id.StartsWith("ManifestObject"))
            {
                XmlNode manifestNode = xSignature.SelectSingleNode("//ds:Manifest[@Id='" + id + "']", xNS);
                string s = manifestNode.OuterXml;

                // The XmlDsigC14NTranswill strip the UTF8 BOM
                using (MemoryStream msIn = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(s)))
                {
                    XmlDsigC14NTransform t = new XmlDsigC14NTransform(true);
                    t.LoadInput(msIn);

                    HashAlgorithm hash = null;
                    switch (alg)
                    {
                        case "http://www.w3.org/2000/09/xmldsig#sha1":
                            hash = new System.Security.Cryptography.SHA1Managed();
                            break;
                        case "http://www.w3.org/2001/04/xmldsig-more#sha224":
                            //hash = new System.Security.Cryptography.SH();
                            break;
                        case "http://www.w3.org/2001/04/xmlenc#sha256":
                            hash = new System.Security.Cryptography.SHA256Managed();
                            break;
                        case "http://www.w3.org/2001/04/xmldsig-more#sha384":
                            hash = new System.Security.Cryptography.SHA384Managed();
                            break;
                        case "http://www.w3.org/2001/04/xmlenc#sha512":
                            hash = new System.Security.Cryptography.SHA512Managed();
                            break;
                    }

                    if (hash == null)
                        return "hash algorithm ERROR (" + alg + ")";

                    byte[] digest = t.GetDigestedOutput(hash);
                    //string result = BitConverter.ToString(digest).Replace("-", String.Empty);
                    string result = Convert.ToBase64String(digest);
                    if (result.Equals(digestValue))
                        return string.Empty;
                    else
                    {
                       return  "digest value ERROR";                      
                    }


                }
            }

            return string.Empty;

            //throw new NotImplementedException();
        }

        /// <summary>
        /// verify sign using BCCrypto
        /// </summary>
        /// <param name="certificateData">signature certificate</param>
        /// <param name="signature">signature value</param>
        /// <param name="data">signed data</param>
        /// <param name="digestAlg">digest alg used with signature</param>
        /// <param name="errorMessage">output error message</param>
        /// <returns>true if signature is valid</returns>
        private string verifySign(byte[] certificateData, byte[] signature, byte[] data, string digestAlg)
        {
            string errorMessage = string.Empty ;
            try
            {
                Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo ski = Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(certificateData)).SubjectPublicKeyInfo;
                Org.BouncyCastle.Crypto.AsymmetricKeyParameter pk = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(ski);

                string algStr = ""; //signature alg

                //find digest
                switch (digestAlg)
                {
                    case "http://www.w3.org/2000/09/xmldsig#rsa-sha1":
                        algStr = "sha1";
                        break;
                    case "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256":
                        algStr = "sha256";
                        break;
                    case "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384":
                        algStr = "sha384";
                        break;
                    case "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512":
                        algStr = "sha512";
                        break;
                }
                if (string.IsNullOrEmpty(algStr))
                    return "alorithm ERROR (" + digestAlg + ")";

                //find encryption
                switch (ski.AlgorithmID.ObjectID.Id)
                {
                    case "1.2.840.10040.4.1": //dsa
                        algStr += "withdsa";
                        break;
                    case "1.2.840.113549.1.1.1": //rsa
                        algStr += "withrsa";
                        break;
                    default:
                        return "verifySign 5: Unknown key algId = " + ski.AlgorithmID.ObjectID.Id;
                        //return false;
                }

                //return errorMessage = "verifySign 8: Creating signer: " + algStr;
                Org.BouncyCastle.Crypto.ISigner verif = Org.BouncyCastle.Security.SignerUtilities.GetSigner(algStr);
                verif.Init(false, pk);
                verif.BlockUpdate(data, 0, data.Length);
                bool res = verif.VerifySignature(signature);
                if (!res)
                {
                    return "verifySign 9: VerifySignature=false";
                }
                return string.Empty;
            }


            catch (Exception ex)
            {
                return "verifySign 10: " + ex.ToString();

            }
        }


    }
}

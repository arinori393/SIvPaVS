using System;
using System.Xml;
using System.Xml.Linq;


namespace SIvPaVS_Podatelna
{
    internal class CoreValidation
    {
        private object BouncyCastle;

        public CoreValidation()
        {
        }

        internal string Validate(XDocument xml)
        {
            var xSignature = DocumentExtensions.ToXmlDocument(xml);
            XmlNamespaceManager xNS = new XmlNamespaceManager(xSignature.NameTable);

            xNS.AddNamespace("ds", Helpers.ds.NamespaceName);


            byte[] signatureCertificate = Convert.FromBase64String(xSignature.SelectSingleNode(@"//ds:KeyInfo/ds:X509Data/ds:X509Certificate", xNS).InnerText);
            byte[] signature = Convert.FromBase64String(xSignature.SelectSingleNode(@"//ds:SignatureValue", xNS).InnerText);
            XmlNode signedInfoN = xSignature.SelectSingleNode(@"//ds:SignedInfo", xNS);
            string signedInfoTransformAlg = xSignature.SelectSingleNode(@"//ds:SignedInfo/ds:CanonicalizationMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;
            string signedInfoSignatureAlg = xSignature.SelectSingleNode(@"//ds:SignedInfo/ds:SignatureMethod", xNS).Attributes.GetNamedItem("Algorithm").Value;
            byte[] objSignedInfoOld = this.canonicalize(this.beforeCanonicalize(signedInfoN, true), signedInfoTransformAlg);
            byte[] objSignedInfoNew = this.canonicalize(this.beforeCanonicalize(signedInfoN), signedInfoTransformAlg);

            string errMsg = "";
            bool res = this.verifySign(signatureCertificate, signature, objSignedInfoNew, signedInfoSignatureAlg, out errMsg);
            if (!res)
            {
                res = this.verifySign(signatureCertificate, signature, objSignedInfoOld, signedInfoSignatureAlg, out errMsg);
                if (!res)
                {
                    //this.errorMessage = errMsg;
                    return "core validation ERROR";
                }
            }

            return string.Empty;
        }

        private byte[] canonicalize(object v, string signedInfoTransformAlg)
        {
            throw new NotImplementedException();
        }

        private object beforeCanonicalize(XmlNode signedInfoN)
        {
            throw new NotImplementedException();
        }

        private object beforeCanonicalize(XmlNode signedInfoN, bool v)
        {
            throw new NotImplementedException();
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
        private bool verifySign(byte[] certificateData, byte[] signature, byte[] data, string digestAlg, out string errorMessage)
        {
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
                        errorMessage = "verifySign 5: Unknown key algId = " + ski.AlgorithmID.ObjectID.Id;
                        return false;
                }

                errorMessage = "verifySign 8: Creating signer: " + algStr;
                Org.BouncyCastle.Crypto.ISigner verif = Org.BouncyCastle.Security.SignerUtilities.GetSigner(algStr);
                verif.Init(false, pk);
                verif.BlockUpdate(data, 0, data.Length);
                bool res = verif.VerifySignature(signature);
                if (!res)
                {
                    //errorMessage = "verifySign 9: VerifySignature=false: dataB64=" + Convert.ToBase64String(data) + Environment.NewLine + "signatureB64=" + Convert.ToBase64String(signature)––– +Environment.NewLine + "certificateDataB64=" + Convert.ToBase64String(certificateData);
                }

                return res;

            }
            catch (Exception ex)
            {
                errorMessage = "verifySign 10: " + ex.ToString();
                return false;
            }
        }


    }
}

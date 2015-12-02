using Org.BouncyCastle.Tsp;
using System;
using System.Collections;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    internal class TimestampValidation
    {
        public TimestampValidation()
        {
        }

        internal string Validate(XDocument xml)
        {
            return string.Empty;
        }

        private byte[] getTimeStampSignatureCertificate(byte[] tsResponse)
        {
            try
            {
                TimeStampResponse tsResp = new TimeStampResponse(tsResponse);
                TimeStampToken token = new TimeStampToken(new Org.BouncyCastle.Cms.CmsSignedData(tsResp.TimeStampToken.GetEncoded()));
                Org.BouncyCastle.X509.X509Certificate signerCert = null;
                Org.BouncyCastle.X509.Store.IX509Store x509Certs = tsResp.TimeStampToken.GetCertificates("Collection");
                ArrayList certs = new ArrayList(x509Certs.GetMatches(null));

                // nájdenie podpisového certifikátu tokenu v kolekcii
                foreach (Org.BouncyCastle.X509.X509Certificate cert in certs)
                {
                    string cerIssuerName = cert.IssuerDN.ToString(true, new Hashtable());
                    string signerIssuerName = token.SignerID.Issuer.ToString(true, new Hashtable());

                    // kontrola issuer name a seriového čísla
                    if (cerIssuerName == signerIssuerName &&
                        cert.SerialNumber.Equals(token.SignerID.SerialNumber))
                    {
                        signerCert = cert;
                        break;
                    }
                }

                return signerCert.GetEncoded();
            }
            catch (Exception ex)
            {
                //this.errorMessage = "Tsa.getTimeStampSignatureCertificate 9: " + ex.Message;
                return null;
            }
        }
    }
}
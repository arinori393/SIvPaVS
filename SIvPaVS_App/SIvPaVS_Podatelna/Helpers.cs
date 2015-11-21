using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    public static class Helpers
    {
        public static XNamespace xzep = "http://www.ditec.sk/ep/signature_formats/xades_zep/v1.0";// "http://www.ditec.sk/ep/signature_formats/xades_zep/v1.01";
        public static XNamespace ds = "http://www.w3.org/2000/09/xmldsig#";

        public static string CanonicalizationRef = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";


        public static List<string> DigestMethodAlgorithm = new List<string>(new string[] {
            "http://www.w3.org/2000/09/xmldsig#sha1",
            "http://www.w3.org/2001/04/xmldsigmore#sha224",
            "http://www.w3.org/2001/04/xmlenc#sha256",
            "http://www.w3.org/2001/04/xmldsigmore#sha384",
            "http://www.w3.org/2001/04/xmlenc#sha512"

        });



        public static List<string> SignAlgorithms = new List<string>(new string[] {
            "http://www.w3.org/2000/09/xmldsig#dsa-sha1",
            "http://www.w3.org/2000/09/xmldsig#rsa-sha1",
            "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256",
            "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384",
            "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512"
        });


}


        public static class DocumentExtensions
        {
            public static XmlDocument ToXmlDocument(this XDocument xDocument)
            {
                var xmlDocument = new XmlDocument();
                using (var xmlReader = xDocument.CreateReader())
                {
                    xmlDocument.Load(xmlReader);
                }
                return xmlDocument;
            }

            public static XDocument ToXDocument(this XmlDocument xmlDocument)
            {
                using (var nodeReader = new XmlNodeReader(xmlDocument))
                {
                    nodeReader.MoveToContent();
                    return XDocument.Load(nodeReader);
                }
            }



        }
    
}

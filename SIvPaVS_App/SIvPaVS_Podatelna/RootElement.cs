using System;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    internal class RootElement
    {
        public RootElement()
        {
        }

        internal string ContainsAttributes(XDocument xml)
        {
            //XName xname = new );

            //xname.Namespace = "xmlns";

            string xzep = "xmlns:xzep=\"http://www.ditec.sk/ep/signature_formats/xades_zep/v1.0\"";// "http://www.ditec.sk/ep/signature_formats/xades_zep/v1.01";
            string ds = "xmlns:ds=\"http://www.w3.org/2000/09/xmldsig#\"";

            var attributes = xml.Root.Attributes();
            foreach (var attr in attributes)
            {
                if (attr.ToString() != xzep && attr.ToString() != ds)
                    return "koreňový element neobsahuje atribút(y) xmlns:xzep a/alebo xmlns:ds podľa profilu XADES_ZEP";

            }
            return string.Empty;
        }
    }
}
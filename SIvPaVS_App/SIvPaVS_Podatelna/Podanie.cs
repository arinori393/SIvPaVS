using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    public class Podanie
    {
        internal string IsValid(XDocument xml)
        {
            string result = string.Empty;

            //•	koreňový element musí obsahovať atribúty xmlns:xzep a xmlns:ds podľa profilu XADES_ZEP.
            result = new RootElement().ContainsAttributes(xml);
            if (result != string.Empty)
                return result;


            //•	kontrola obsahu ds:SignatureMethod a ds:CanonicalizationMethod – musia obsahovať URI niektorého z podporovaných algoritmov pre dané elementy podľa profilu XAdES_ZEP,
            result = new ContentContainsAlgorithmsReferences().ContainsReferences(xml);
            if (result != string.Empty)
                return result;



            //•	kontrola obsahu ds:Transforms a ds:DigestMethod vo všetkých referenciách v ds:SignedInfo – musia obsahovať URI niektorého z podporovaných algoritmov podľa profilu XAdES_ZEP,
            result = new TransformsReferences().HasValidReferences(xml);
            if (result != string.Empty)
                return result;


            //•	Core validation (podľa špecifikácie XML Signature) – overenie hodnoty podpisu ds:SignatureValue a referencií v ds:SignedInfo:
            result = new CoreValidation().Validate(xml);
            if (result != string.Empty)
                return result;


            return "VALID";
        }
    }
}

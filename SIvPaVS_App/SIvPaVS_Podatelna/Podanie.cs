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
        internal string IsValid(XDocument xml, int validationStep = 0)
        {
            string result = string.Empty;

            //•	koreňový element musí obsahovať atribúty xmlns:xzep a xmlns:ds podľa profilu XADES_ZEP.
            if (validationStep == 0 || validationStep == 1)
            result = new RootElement().ContainsAttributes(xml);
            if (result != string.Empty)
                return result;


            //•	kontrola obsahu ds:SignatureMethod a ds:CanonicalizationMethod – musia obsahovať URI niektorého z podporovaných algoritmov pre dané elementy podľa profilu XAdES_ZEP,
            if (validationStep == 0 || validationStep == 2)
                result = new ContentContainsAlgorithmsReferences().ContainsReferences(xml);
            if (result != string.Empty)
                return result;



            //•	kontrola obsahu ds:Transforms a ds:DigestMethod vo všetkých referenciách v ds:SignedInfo – musia obsahovať URI niektorého z podporovaných algoritmov podľa profilu XAdES_ZEP,
            if (validationStep == 0 || validationStep == 3)
                result = new TransformsReferences().HasValidReferences(xml);
            if (result != string.Empty)
                return result;


            //•	Core validation (podľa špecifikácie XML Signature) – overenie hodnoty podpisu ds:SignatureValue a referencií v ds:SignedInfo:
            if (validationStep == 0 || validationStep == 4)
                result = new CoreValidation().Validate(xml);
            if (result != string.Empty)
                return result;

            //• overenie ostatnych elementov profilu XADES_ZEP, ktore prinalezia do specifikacie XML Signature
            if (validationStep == 0 || validationStep == 5)
                result = new ElementContentValidation().Validate(xml);
            if (result != string.Empty)
                return result;

            return "VALID";
        }
    }
}

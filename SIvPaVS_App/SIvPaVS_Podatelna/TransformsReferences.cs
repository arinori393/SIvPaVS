using System;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    internal class TransformsReferences
    {
        public TransformsReferences()
        {
        }

        internal string HasValidReferences(XDocument xml)
        {
            var signedInfo = xml.Descendants(Helpers.ds + "SignedInfo");

            var transformsElements = signedInfo.Descendants(Helpers.ds + "Transforms");


            foreach (var trans in transformsElements)
            {

                if (trans.Element(Helpers.ds + "Transform").Attribute("Algorithm").Value != Helpers.CanonicalizationRef)
                    return "ds:Transform neobsahuje URI z podporovaného algoritmu";
            }
            

            transformsElements = signedInfo.Descendants(Helpers.ds + "DigestMethod");

            foreach (var trans in transformsElements)
            {
                if (!Helpers.DigestMethodAlgorithm.Contains(trans.Attribute("Algorithm").Value))
                    return "ds:DigestMethod neobsahuje URI niektorého z podporovaných algoritmov";
            }


            return string.Empty;

        }
    }
}
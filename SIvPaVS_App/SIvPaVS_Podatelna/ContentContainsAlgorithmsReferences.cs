using System;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    internal class ContentContainsAlgorithmsReferences
    {
        public ContentContainsAlgorithmsReferences()
        {
        }

        internal string ContainsReferences(XDocument xml)
        {
            var signature = xml.Descendants(Helpers.ds + "SignatureMethod");

            var signAlgorithmlist = signature.Attributes("Algorithm");

            foreach (var signAlgorithm in signAlgorithmlist)
            {
                if (!Helpers.SignAlgorithms.Contains(signAlgorithm.Value))
                    return "ds:SignatureMethod neobsahuje URI niektorého z podporovaných algoritmov";
            }

            var canonicallist = xml.Descendants(Helpers.ds + "CanonicalizationMethod").Attributes("Algorithm");

            foreach (var canonical in canonicallist)
            {
                if (canonical.Value != Helpers.CanonicalizationRef)
                    return "ds:CanonicalizationMethod neobsahuje URI podporovaného algoritmu";
            }
            return string.Empty;
        }
    }
}
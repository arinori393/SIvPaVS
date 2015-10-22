using System.IO;
using System.Windows.Forms;

namespace SIvPaVS_App
{
    internal class Signer
    { 
        private string xml;

        public Signer(string xml)
        {
            this.xml = xml;
        }

        public string SignXml() {

            //Ditec_Zep_DSigXadesAtl.CXadesSigAtlClass;
            Ditec_Zep_DSigXades_XmlPluginAtl.CPluginAtl signer =new  Ditec_Zep_DSigXades_XmlPluginAtl.CPluginAtl();
            var a = Path.GetDirectoryName(Application.ExecutablePath);
            var signerObj = signer.CreateObject("receipts", "Pokladničný blok", xml, Resources.receipts,"", a + @"\..\..\Resources\receipts.xsd", Resources.XML_to_TXT_XSLT, a + @"\..\..\Resources\XML_to_TXT_XSLT.xsl");


            Ditec_Zep_DSigXadesAtl.CXadesSigAtl oXML = new Ditec_Zep_DSigXadesAtl.CXadesSigAtl();

            oXML.AddObject(signerObj);

            var result = oXML.Sign("signID", "sha256", "urn:oid:1.3.158.36061701.1.2.1");

            if (result == 0)
            {
                return oXML.SignedXmlWithEnvelope;
            }
            else
            {
                MessageBox.Show(oXML.ErrorMessage, "SignerError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

        }
    }
}
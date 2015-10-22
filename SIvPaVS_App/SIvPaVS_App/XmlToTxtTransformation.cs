using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace SIvPaVS_App
{
    class XmlToTxtTransformation
    {
        string _xml;
        string _xslt;
        public XmlToTxtTransformation(string xml, string xslt, bool isXmlPath = false, bool isXsltPath = false)
        {

            if (isXmlPath)
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(xml);
                _xml = xmlDocument.InnerXml;

            }
            else
                this._xml = xml;
            if (isXmlPath)
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(xslt);
                _xslt = xmlDocument.InnerXml;

            }
            else
                this._xslt = xslt;
            
        }
    
        public string f_TransformXml()
        {


            XmlDocument sourceXmlDocument = new XmlDocument();
            sourceXmlDocument.LoadXml(_xml);
            XslCompiledTransform transformer = new XslCompiledTransform();
            XmlTextReader xsltReader = new XmlTextReader(new StringReader(_xslt));
            transformer.Load(xsltReader);
            MemoryStream outputStream = new MemoryStream();
            XmlWriter xmlWriter = XmlWriter.Create(outputStream, transformer.OutputSettings);
            transformer.Transform(sourceXmlDocument, null, xmlWriter);
            outputStream.Position = 0;
            StreamReader streamReader = new StreamReader(outputStream);

            return streamReader.ReadToEnd();
    
    }



    }
}

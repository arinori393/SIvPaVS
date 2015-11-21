using SIvPaVS_App.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Org.BouncyCastle.Tsp;
using Org.BouncyCastle.Asn1.Cms;

namespace SIvPaVS_App
{
    public partial class form_Main : Form
    {


        #region Variables
        // Prosim davat kazdej premennej prefix v_
        // Priklad: v_premennaXY
        // Este keby sme davali aj prefixi typu premennej, tak by to bolo super
        // Priklad: v_str_stringovaPremennaXY
        public receiptType Receipt;
        private bool isValidated;
        private XmlDocument document;
        private string signedXml;

        #endregion

        #region Properties
        // Prosim davat kazdej vlastnosti prefix p_
        // Priklad: p_vlastnostXY
        // + to iste co pri premennych
        // Priklad: p_str_stringovaVlastnostXY

        public static List<ItemSection> ItemSections;


        #endregion

        #region Constructor

        public form_Main()
        {
            InitializeComponent();
            Receipt = new receiptType();
            isValidated = false;

            ComboBox.ObjectCollection CountryList = this.cbCountry.Items;
            CountryList.AddRange(new string[]  {"Afganistan", "Albánsko", "Alžírsko", "Andorra", "Angola", "Antigua a Barbuda", "Argentína", "Arménsko",
                                                "Austrália", "Azerbajdžan", "Bahamy", "Bahrajn", "Bangladéš", "Barbados", "Belgicko", "Belize", "Benin", 
                                                "Bhután", "Bielorusko", "Bolívia", "Bosna a Hercegovina", "Botswana", "Brazília", "Brunej", "Bulharsko", 
                                                "Burkina", "Burundi", "Cookove ostrovy", "Cyprus", "Čad", "Česko", "Čierna Hora", "Čile", "Čína", "Dánsko",
                                                "Dominika", "Dominikánska republika", "Džibutsko", "Egypt", "Ekvádor", "Eritrea", "Estónsko", "Etiópia", 
                                                "Fidži", "Filipíny", "Fínsko", "Francúzsko", "Gabon", "Gambia", "Ghana", "Grécko", "Grenada", "Gruzínsko", 
                                                "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holandsko", "Honduras", "Chorvátsko", "India", 
                                                "Indonézia", "Irak", "Irán", "Írsko", "Island", "Izrael", "Jamajka", "Japonsko", "Jemen", "Jordánsko", 
                                                "Južná Afrika", "Južný Sudán", "Kambodža", "Kamerun", "Kanada", "Kapverdy", "Katar", "Kazachstan", "Keňa", 
                                                "Kirgizsko", "Kiribati", "Kolumbia", "Komory", "Kongo", "Kongo (býv. Zair)", 
                                                "Kórejská ľudovodemokratická republika", "Kórejská republika", "Kosovo", "Kostarika", "Kuba", "Kuvajt",
                                                "Laos", "Lesotho", "Libanon", "Libéria", "Líbya", "Lichtenštajnsko", "Litva", "Lotyšsko", "Luxembursko", 
                                                "Macedónsko", "Madagaskar", "Maďarsko", "Malajzia", "Malawi", "Maldivy", "Mali", "Malta", "Maroko", 
                                                "Marshallove ostrovy", "Maurícius", "Mauritánia", "Mexiko", "Mikronézia", "Mjanmarsko", "Moldavsko",
                                                "Monako", "Mongolsko", "Mozambik", "Namíbia", "Nauru", "Nemecko", "Nepál", "Niger", "Nigéria", "Nikaragua", 
                                                "Niue", "Nórsko", "Nový Zéland", "Omán", "Pakistan", "Palau", "Panama", "Papua-Nová Guinea", "Paraguaj", 
                                                "Peru", "Pobrežie Slonoviny", "Poľsko", "Portugalsko", "Rakúsko", "Rovníková Guinea", "Rumunsko", "Rusko", 
                                                "Rwanda", "Salvádor", "Samoa", "San Maríno", "Saudská Arábia", "Senegal", "Seychely", "Sierra Leone", "Singapur", 
                                                "Slovensko", "Slovinsko", "Somálsko", "Spojené arabské emiráty", "Spojené kráľovstvo (Veľká Británia)",
                                                "Spojené štáty (USA)", "Srbsko", "Srí Lanka", "Stredoafrická republika", "Sudán", "Surinam", "Svazijsko",
                                                "Svätá Lucia", "Svätý Krištof a Nevis", "Svätý Tomáš a Princov ostrov", "Svätý Vincent a Grenadíny", "Sýria",
                                                "Šalamúnove ostrovy", "Španielsko", "Švajčiarsko", "Švédsko", "Tadžikistan", "Taiwan", "Taliansko", "Tanzánia", 
                                                "Thajsko", "Togo", "Tonga", "Trinidad a Tobago", "Tunisko", "Turecko", "Turkménsko", "Tuvalu", "Uganda", "Ukrajina",
                                                "Uruguaj", "Uzbekistan", "Vanuatu", "Vatikán", "Venezuela", "Vietnam", "Východný Timor", "Zambia", "Západná Sahara",
                                                "Zimbabwe" });
            cbCountry.Text = "Slovensko";
            dtTime.Value = DateTime.Now;
            f_SetControlsFromEntity();       
        }


        #endregion

        #region Functions
        // Prosim davat kazdej funkcii prefix f_
        // Priklad: f_funkciaXY

        public void f_SetEntityFromControls()
        {
            f_SetReceiptEntityFromControls();
            f_SetItemsEntityFromControls();

        }

        private void f_SetReceiptEntityFromControls()
        {
            isValidated = false;
            Receipt.taxpercentage = int.Parse(tbTAXPercentage.Text);
            Receipt.provider.name = tbCompanyName.Text;
            Receipt.provider.companyregnum = tbCompanyRegNumber.Text;
            Receipt.provider.vatregnum =  tbCompanyTaxNumber.Text;

            Receipt.provider.address.street = tbStreet.Text;
            Receipt.provider.address.city = tbCity.Text;
            Receipt.provider.address.zip = tbZIP.Text;
            Receipt.provider.address.country = cbCountry.Text;

            Receipt.taxcode = tbTaxCode.Text;
            Receipt.issuedat = dtTime.Value;

        }

        public void f_SetItemsEntityFromControls(int itemCountDifference = 0)
        {
            Receipt.items = new itemType[ItemSections.Count + itemCountDifference];

            for (int i = 0; i < ItemSections.Count; i++)
            {
                Receipt.items[i] = ItemSections[i].f_GetEntity();
            }
        }

        public void f_SetControlsFromEntity()
        {

            if(Receipt.provider != null)
                f_SetProviderControlsFromEntity(Receipt.provider);

            if (Receipt.issuedat > dtTime.MaxDate)
                dtTime.Value = DateTime.Now; //dtTime.MaxDate;
            else if (Receipt.issuedat < dtTime.MinDate)
                dtTime.Value = DateTime.Now; //dtTime.MinDate;
            else
                dtTime.Value = Receipt.issuedat;
            tbTaxCode.Text = Receipt.taxcode;

            f_SetItems(Receipt.items);

        }

        private void f_SetSummaryControlsFromEntity()
        {
            tbTAXBase.Text = Receipt.TAXBase.ToString();
            tbTAXPercentage.Text = Receipt.taxpercentage.ToString();
            tbTAXTotal.Text = Receipt.TAXTotal.ToString();
            tbTotalPrice.Text = Receipt.TotalPrice.ToString();
        }

        private void f_SetProviderControlsFromEntity(businessobjectType provider = null)
        {
            if (provider == null)
                provider = Receipt.provider;

            tbCompanyName.Text = provider.name;
            tbCompanyRegNumber.Text = provider.companyregnum;
            tbCompanyTaxNumber.Text = provider.vatregnum;

            var address = provider.address;

            if (address != null)
            tbStreet.Text = address.street;
            tbCity.Text = address.city;
            tbZIP.Text = address.zip;
            cbCountry.Text = string.IsNullOrEmpty(address.country) ? "Slovensko" : address.country;

        }

        public void f_SetItems(itemType[] Items = null)
        {
            if (Items == null)
                Items = Receipt.items;

            ItemSections = new List<ItemSection>();

            if  (Items != null && Items.Count() > 0)
                foreach (var item in Items)
                    if (item != null)
                        ItemSections.Add(new ItemSection(item));

                    else
                        ItemSections.Add(new ItemSection());
            else
                ItemSections.Add(new ItemSection());

            panelItems.Controls.Clear();
                
            int counter = 0;
            foreach (var item in ItemSections)
            {

                item.f_SetControlsFromEntity(counter + 1,this, counter == ItemSections.Count()-1);
                panelItems.Controls.Add(ItemSections[counter++]);
            }

            f_SetSummaryControlsFromEntity();
        }

        public void f_RemoveItem(int position = 0)
        {
            
            if (position == 0)
                ItemSections.RemoveAt(0);
            else
                ItemSections.RemoveAt(position);

            f_SetItemsEntityFromControls();

            f_SetItems(Receipt.items);
        }

        internal void f_AddItem()
        {
            f_SetItemsEntityFromControls(1);
            ItemSections.Add(new ItemSection());
            Receipt.items[Receipt.items.Count()-1] = new itemType(); 
            f_SetItems(Receipt.items);
        }


        private bool f_ValidateControls(Control parentControl)
        {
            bool isValid = true;
            foreach (Control controlItem in parentControl.Controls)
            {
                if (controlItem is TextBox)
                {
                    if ((controlItem.BackColor == Color.FromArgb(255, 128, 128)) || controlItem.BackColor == SystemColors.Window)
                    {
                        if (string.IsNullOrEmpty(controlItem.Text))
                        {
                            controlItem.BackColor = Color.FromArgb(255, 128, 128);
                            isValid = false;
                        }
                        else
                            controlItem.BackColor = SystemColors.Window; //Color.ReferenceEquals.;
                    }
                }
                else if (controlItem.Controls != null && controlItem.Controls.Count > 0)
                   isValid = !isValid ? isValid :f_ValidateControls(controlItem);

            }
            return isValid;
        }



        private void f_SaveAs(string format)
        {
            if (isValidated)
            {
                var receipts = new receiptsType();
                receipts.receipt = Receipt;
                Receipt.id = "1";

                string file = DateTime.Now.ToString("dd.MM.yyyy_hhmmss") + "-" + Receipt.provider.companyregnum;
                DialogResult result = fbdSelectSavingPlace.ShowDialog();
                if (result == DialogResult.OK)
                {
                    file = fbdSelectSavingPlace.SelectedPath + "\\" + file + "." + format.ToLower();
                    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(receipts.GetType());

                    if (format.ToLower() == "xml")
                    {
                        Stream writer = new FileStream(file, FileMode.Create);
                        serializer.Serialize(writer, receipts);
                        writer.Close();

                    }
                    else if (format.ToLower() == "txt")
                    {
                        XmlToTxtTransformation transformation;
                        using (StringWriter textWriter = new StringWriter())
                        {
                            serializer.Serialize(textWriter, receipts);
                        
                            transformation = new XmlToTxtTransformation(textWriter.ToString(), Resources.XML_to_TXT_XSLT);
                        }
                        File.WriteAllText(file, transformation.f_TransformXml());
                    }

                }
                else if (result == DialogResult.Cancel)
                {
                    
                }
                else
                    MessageBox.Show("Nastala chyba pri výbere miesta uloženia. Prosím opakujte.", "Chyba výberu miesta uloženia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Pred uložením prosím validujte formulár stlačením tlačidla 'Validuj'.", "Chyba validácie!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        private void f_LoadReceiptFromXml()
        {

            Receipt = new receiptType();

            ofdLoadXml.Filter = "XML Files (*.xml)|*.xml";
            DialogResult result = ofdLoadXml.ShowDialog();
            if (result == DialogResult.OK)
            {

                if (f_validateXML("http://www.w3.org/2001/XMLSchema", ofdLoadXml.FileName))
                {
                    MessageBox.Show("Vybratý XML súbor je validný!", "XSD Validation OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f_serializeXmlToReceiptObject();
                    isValidated = true;
                }                

            }//var file = ofdLoadXml.
            else
                MessageBox.Show("Nastala chyba pri načítavaní súboru!","ERROR!",MessageBoxButtons.OK, MessageBoxIcon.Error);

            f_SetControlsFromEntity() ;
        }

        private void f_serializeXmlToReceiptObject()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(receiptsType));
            using (TextReader reader = new StringReader(document.InnerXml))
            {
                receiptsType result = (receiptsType)serializer.Deserialize(reader);
                Receipt = result.receipt;
            }
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }

        }

        protected bool f_validateXML(string nameSpace, string filePath)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", XmlReader.Create(new StringReader(Resources.receipts)));


            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add(schemas);
            settings.ValidationType = ValidationType.Schema;

            XmlReader reader = XmlReader.Create(filePath, settings);
            document = new XmlDocument();

            try
            {
                document.Load(reader);

                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);

                // the following call to Validate succeeds.
                document.Validate(eventHandler);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "XML nie je validné!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        private void f_SignXml()
        {
            if (isValidated)
            {
                var receipts = new receiptsType();
                receipts.receipt = Receipt;
                Receipt.id = "1";

                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(receipts.GetType());

                
                using (StringWriter textWriter = new StringWriter())
                        {

                    serializer.Serialize(textWriter, receipts);
                    
                    XmlDocument doc = new XmlDocument();

                    doc.InnerXml = textWriter.ToString();


                    Signer signer = new Signer(doc.InnerXml.ToString());
                    signedXml = signer.SignXml();

                    string file = DateTime.Now.ToString("dd.MM.yyyy_hhmmss") + "-" + Receipt.provider.companyregnum+ "_signed";
                    DialogResult result = fbdSelectSavingPlace.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        file = fbdSelectSavingPlace.SelectedPath + "\\" + file + ".xml";
                        File.WriteAllText(file, signedXml = signer.SignXml());

                    }
                }
            }
            else
                MessageBox.Show("Pred podpísaním prosím validujte formulár stlačením tlačidla 'Validuj'.", "Chyba validácie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
        private void f_AddTimeStamp()
        {
            ofdLoadXml.Filter = "XML Files (*.xml)|*.xml";
            DialogResult result = ofdLoadXml.ShowDialog();
            if (result == DialogResult.OK)
            {

                XmlReader reader = XmlReader.Create(ofdLoadXml.FileName);
                XmlDocument xml = new XmlDocument();
                xml.Load(reader);

                var namespaceId = new XmlNamespaceManager(xml.NameTable);
                namespaceId.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");

                string data = getBase64Data(xml.SelectSingleNode("//ds:SignatureValue", namespaceId)); // todo: x-path to select node

                TimeStampService.TSSoapClient tsClient = new TimeStampService.TSSoapClient();
                var timestamp = tsClient.GetTimestamp(data);

                TimeStampResponse response = new TimeStampResponse(Convert.FromBase64CharArray(timestamp.ToCharArray(), 0, timestamp.Length));
                XNamespace namespaceAdd = "http://uri.etsi.org/01903/v1.3.2#";

                namespaceId.AddNamespace("xades", "http://uri.etsi.org/01903/v1.3.2#");
                var partialxml = xml.SelectSingleNode("//xades:QualifyingProperties", namespaceId);

                XDocument doc = XDocument.Load(ofdLoadXml.FileName);
                XNamespace namespacePrefix = "http://uri.etsi.org/01903/v1.3.2#";
                XElement desc = doc.Descendants(namespacePrefix + "QualifyingProperties").Last();

                desc.Add(
                    new XElement(namespacePrefix + "UnsignedProperties",
                        new XElement(namespacePrefix + "UnsignedSignatureProperties",
                            new XElement(namespacePrefix + "SignatureTimeStamp", 
                                new object[] { new XAttribute("Id", "SignatureTimeStampId"),
                                        new XElement(namespacePrefix + "EncapsulatedTimeStamp",
                                            Convert.ToBase64String(response.TimeStampToken.GetEncoded())) }
                                )
                            )
                        )
                    );

                XElement EncapsulatedTimeStamp = new XElement(namespacePrefix + "EncapsulatedTimeStamp", Convert.ToBase64String(response.TimeStampToken.GetEncoded()));
                doc.Save(ofdLoadXml.FileName.Replace(".xml", "_time.xml"));
            }
            else
                MessageBox.Show("Nastala chyba pri načítavaní súboru!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static XmlNode GetXmlNode(XElement element)
        {
            using (XmlReader xmlReader = element.CreateReader())
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlReader);
                return xmlDoc;
            }
        }

        private string getBase64Data(XmlNode xmlNode)
        {
            //return Convert.ToBase64String(Encoding.UTF8.GetBytes(xmlNode.InnerXml.ToString()));
            return xmlNode.InnerXml;
        }

        
        #endregion

        #region EventHandlers
        // Prosim davat kazdemu handleru prefix eh_
        // Priklad: eh_eventhandlerXY

        private void eh_tsmi_File_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(tsmi_FileNew))
                {
                    DialogResult dialogResult = MessageBox.Show("Chcete uložiť aktuálne vyplnený formulár?", "Uložiť?", MessageBoxButtons.YesNoCancel);

                    if (dialogResult == DialogResult.Cancel)
                        return;
                    else if(dialogResult == DialogResult.Yes)
                        f_SaveAs("xml");

                    Receipt = new receiptType();
                    f_SetControlsFromEntity();
                }
                else if (sender.Equals(tsmi_FileSaveXML))
                {
                    f_SaveAs("xml");
                }
                else if (sender.Equals(tsmi_FileSaveTXT))
                {
                    f_SaveAs("txt");
                }
                else if (sender.Equals(tsmi_FileExit))
                {
                    this.Close();
                }
                else if (sender.Equals(tsmi_Open))
                {
                    f_LoadReceiptFromXml();
                }
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.ToString(), "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void cbManualTime_CheckedChanged(object sender, EventArgs e)
        {
            dtTime.Enabled = cbManualTime.Checked;

            if (!cbManualTime.Checked)
                dtTime.Value = DateTime.Now;
            

        }

        private void eh_TAXPercentageValidation(object sender, CancelEventArgs e)
        {
            Errors.Clear();
            TextBox tbSender = sender as TextBox;
            //string errorMsg;

            int a = 0;

            try
            {
                a = (int.Parse(tbSender.Text));
            }
            catch
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tbSender.Select(0, tbSender.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.Errors.SetError(tbSender, "Nesprávny formát čísla! (celé číslo je povinné)");
            }

            if (a > 99 || a < 0)
            {
                this.Errors.SetError(tbSender, "Nesprávny rozsah čísla! (0-99)");
                e.Cancel = true;
                tbSender.Select(0, tbSender.Text.Length);
            }
        }
        
        private void eh_TAXPercentageValidated(object sender, EventArgs e)
        {
            Errors.Clear();
            Receipt.taxpercentage = int.Parse((sender as TextBox).Text);
            f_SetSummaryControlsFromEntity();

        }

        private void eh_TaxCodeValidation(object sender, CancelEventArgs e)
        {
            Errors.Clear();
            TextBox tbSender = sender as TextBox;
            var strToValidate = tbSender.Text;

            if (strToValidate.Length != 16)
            {
                e.Cancel = true;
                tbSender.Select(0, tbSender.Text.Length);
                this.Errors.SetError(tbSender, "Nesprávna dĺžka kódu! (počet číslic musí byť 16)");

            }


            for (int i = 0; i < strToValidate.Length; i++)
            {
                char[] charDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                if (!charDigits.Contains(strToValidate[i]))
                {
                    e.Cancel = true;
                    tbSender.Select(i, 1);
                    this.Errors.SetError(tbSender, "Kód musí obsahovať len číslice! ([0-9])");

                }
            }
        }

        private void eh_ProviderDataValidated(object sender, EventArgs e)
        {
            Errors.Clear();
            Receipt.taxcode = (sender as TextBox).Text;
            (sender as TextBox).BackColor = Color.White;
            //f_SetItemsEntityFromControls();
            f_SetReceiptEntityFromControls();

        }

        private void eh_ZIPValidation(object sender, CancelEventArgs e)
        {
            Errors.Clear();
            TextBox tbSender = sender as TextBox;
            var strToValidate = tbSender.Text;

            if (strToValidate.Length != 5)
            {
                e.Cancel = true;
                tbSender.Select(0, tbSender.Text.Length);
                this.Errors.SetError(tbSender, "Nesprávna dĺžka PSČ! (počet číslic musí byť 5)");

            }


            for (int i = 0; i < strToValidate.Length; i++)
            {
                char[] charDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                if (!charDigits.Contains(strToValidate[i]))
                {
                    e.Cancel = true;
                    tbSender.Select(i, 1);
                    this.Errors.SetError(tbSender, "PSČ musí obsahovať len číslice! ([0-9])");

                }
            }
        }

        private void eh_RegNumberValidation(object sender, CancelEventArgs e)
        {
            Errors.Clear();
            TextBox tbSender = sender as TextBox;
            var strToValidate = tbSender.Text;
           
            if (strToValidate.Length != 8)
            {
                e.Cancel = true;
                tbSender.Select(0, tbSender.Text.Length);
                this.Errors.SetError(tbSender, "Nesprávna dĺžka IČO! (počet číslic musí byť 8)");

            }


            for (int i = 0; i < strToValidate.Length; i++)
            {
                char[] charDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                if (!charDigits.Contains(strToValidate[i]))
                {
                    e.Cancel = true;
                    tbSender.Select(i, 1);
                    this.Errors.SetError(tbSender, "PSČ musí obsahovať len číslice! ([0-9])");

                }
            }

        }


        private void eh_TAXNumberValidation(object sender, CancelEventArgs e)
        {
            Errors.Clear();
            TextBox tbSender = sender as TextBox;
            var strToValidate = tbSender.Text;

            if (strToValidate.Length != 12)
            {
                e.Cancel = true;
                tbSender.Select(0, tbSender.Text.Length);
                this.Errors.SetError(tbSender, "Nesprávna dĺžka IČ DPH! (počet znakov musí byť 12)");

            }

            var formatError = false;
            for (int i = 0; i < strToValidate.Length; i++)
            {
                if (i < 2)
                {
                    if (strToValidate[i] > 90 || strToValidate[i] < 65)
                        formatError = true;
                }
                else
                {
                    char[] charDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    if (!charDigits.Contains(strToValidate[i]))
                        formatError = true;
                }

                if (formatError)
                {
                    e.Cancel = true;
                    tbSender.Select(i, 1);
                    this.Errors.SetError(tbSender, "Nesprávny formát! (Príklad: 'SK0123456789')");
                    break;
                }
            }
        }

        private void eh_btValidate_Click(object sender, EventArgs e)
        {
            f_SetEntityFromControls();

            if (f_ValidateControls(this))
            {
                isValidated = true;
                lbAllFieldsRequired.Visible = false;
                MessageBox.Show("Vyplnený formulár je validný!", "Validácia úspešná!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                lbAllFieldsRequired.Visible = true;
                
        }

        private void eh_ReceiptValueValidate(object sender, CancelEventArgs e)
        {
            f_SetReceiptEntityFromControls();

        }
       
        private ErrorProvider Errors = new ErrorProvider();

        private void eh_btSign_Click(object sender, EventArgs e)
        {
            f_SignXml();
        }
        #endregion

        private void btTimeStamp_Click(object sender, EventArgs e)
        {
            f_AddTimeStamp();
        }


    }
}

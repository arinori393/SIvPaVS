﻿using SIvPaVS_App.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIvPaVS_App.Schema;

namespace SIvPaVS_App
{
    public partial class form_Main : Form
    {


        #region Variables
        // Prosim davat kazdej premennej prefix v_
        // Priklad: v_premennaXY
        // Este keby sme davali aj prefixi typu premennej, tak by to bolo super
        // Priklad: v_str_stringovaPremennaXY
        private ReceiptObject Receipt;
        

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
            Receipt = new ReceiptObject();


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
                dtTime.Value = dtTime.MaxDate;
            else if (Receipt.issuedat < dtTime.MinDate)
                dtTime.Value = dtTime.MinDate;
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
            cbCountry.Text = address.country;

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
                }
                else if (sender.Equals(tsmi_FileSave))
                { 
                }
                else if (sender.Equals(tsmi_FileSaveAs))
                { 
                }
                else if (sender.Equals(tsmi_FileExit))
                {
                    this.Close();
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

        private void eh_TaxCodeValidated(object sender, EventArgs e)
        {
            Errors.Clear();
            Receipt.taxcode = (sender as TextBox).Text;
            f_SetProviderControlsFromEntity();

        }




        #endregion

        private ErrorProvider Errors = new ErrorProvider();
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIvPaVS_App.BusinessObjects;

namespace SIvPaVS_App
{

    public partial class ItemSection : UserControl
    {

        private form_Main parentForm;
        private itemType item;

        public ItemSection()
        {
            InitializeComponent();
            item = new itemType();
        }

        public ItemSection(itemType item)
        {
            InitializeComponent();
            this.item = item;
        }

        internal void f_SetControlsFromEntity(int ID, form_Main form, bool isLast = false)
        {
            parentForm = form;
            lbID.Text = ID.ToString();
            lbAddItem.Visible = isLast;


            cbItemUnit.DataSource = Enum.GetValues(typeof(quantitytypeType));

            tbItemName.Text = item.name;
            tbItemtPrice.Text = item.price.ToString();
            tbItemTotalPrice.Text = item.TotalItemPrice.ToString();
            tbQuantity.Text = item.quantity.ToString();
            cbItemUnit.Text = item.quantitytype.ToString();
        }

      

        #region functions
        internal itemType f_GetEntity()
        {
            f_SetEntityFromControls();
            return this.item;
        }

        private void f_SetEntityFromControls()
        {
            item.name = tbItemName.Text;
            try
            {
                item.price = decimal.Parse(tbItemtPrice.Text);
            }
            catch { item.price = 0; }
            try
            {
                item.quantity = decimal.Parse(tbQuantity.Text);
            }
            catch { item.price = 0; }

            quantitytypeType quantytyType;
            Enum.TryParse<quantitytypeType>(cbItemUnit.SelectedValue.ToString(), out quantytyType);
            item.quantitytype = quantytyType;
        }

        #endregion

        #region events

        private void eh_lbDelete_Click(object sender, EventArgs e)
        {
            parentForm.f_RemoveItem(int.Parse(lbID.Text) - 1 );
        }

        private void lbAddItem_Click(object sender, EventArgs e)
        {
            parentForm.f_AddItem();
        }

        

        private void eh_DecimalNumberValidation(object sender, CancelEventArgs e)
        {
            TextBox tbSender = sender as TextBox;
            //string errorMsg;
            try
            {
                var a = (decimal.Parse(tbSender.Text));
            }
            catch
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tbSender.Select(0, tbSender.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.Errors.SetError(tbSender, "Nesprávny formát čísla!");
            }
        }

        ErrorProvider Errors = new ErrorProvider();

        private void eh_DecimalNumberValidated(object sender, EventArgs e)
        {
            Errors.Clear();
            (sender as TextBox).BackColor = Color.White;
            parentForm.f_SetItemsEntityFromControls();
            parentForm.f_SetItems();

        }
        #endregion
    }
}

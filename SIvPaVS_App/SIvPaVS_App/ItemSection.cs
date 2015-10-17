using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIvPaVS_App
{

    public partial class ItemSection : UserControl
    {

        private form_Main parentForm;

        public ItemSection()
        {
            InitializeComponent();
        }

        internal void f_SetControlsFromEntity(int ID, form_Main form, bool isLast = false)
        {
            parentForm = form;
            lbID.Text = ID.ToString();


            lbAddItem.Visible = isLast;

        }

        private void eh_lbDelete_Click(object sender, EventArgs e)
        {
            parentForm.f_RemoveItem(int.Parse(lbID.Text) - 1 );
        }

        private void lbAddItem_Click(object sender, EventArgs e)
        {
            parentForm.f_AddItem();
        }
    }
}

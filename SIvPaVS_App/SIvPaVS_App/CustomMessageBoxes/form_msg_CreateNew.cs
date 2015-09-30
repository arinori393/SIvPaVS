using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIvPaVS_App.CustomMessageBoxes
{
    public partial class form_msg_CreateNew : Form
    {
        public form_msg_CreateNew()
        {
            InitializeComponent();
        }

        #region EventHandlers

        private void eh_btn_Click(object sender, EventArgs e) 
        {
            try
            {
                if (sender.Equals(btn_Create))
                {
                }
                else if (sender.Equals(btn_Cancel))
                {
                    this.Close();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}

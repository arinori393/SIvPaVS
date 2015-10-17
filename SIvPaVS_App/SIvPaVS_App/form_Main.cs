using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIvPaVS_App
{
    public partial class form_Main : Form
    {
        #region Variables
        // Prosim davat kazdej premennej prefix v_
        // Priklad: v_premennaXY
        // Este keby sme davali aj prefixi typu premennej, tak by to bolo super
        // Priklad: v_str_stringovaPremennaXY

        #endregion

        #region Properties
        // Prosim davat kazdej vlastnosti prefix p_
        // Priklad: p_vlastnostXY
        // + to iste co pri premennych
        // Priklad: p_str_stringovaVlastnostXY

        public static List<ItemSection> Items;


        #endregion

        #region Constructor

        public form_Main()
        {
            InitializeComponent();



            Items = new List<ItemSection>();


            Items.Add(new ItemSection());
            Items.Add(new ItemSection());
            Items.Add(new ItemSection());

            f_SetControlsFromEntity();


         
        }


        #endregion

        #region Functions
        // Prosim davat kazdej funkcii prefix f_
        // Priklad: f_funkciaXY
        private void f_SetControlsFromEntity()
        {

            f_SetItems();
        }

        private void f_SetItems()
        {
            panelItems.Controls.Clear();

            if (Items.Count == 0)
                Items.Add(new ItemSection());
                
            int counter = 0;
            foreach (var item in Items)
            {

                item.f_SetControlsFromEntity(counter + 1,this, counter == Items.Count-1);
                panelItems.Controls.Add(Items[counter++]);
            }


        }

        public void f_RemoveItem(int position = 0)
        {
            if (position == 0)
                Items.RemoveAt(0);
            else
                Items.RemoveAt(position);

            f_SetItems();
        }

        internal void f_AddItem()
        {
            Items.Add(new ItemSection());
            f_SetItems();
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


        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SIvPaVS_Podatelna
{
    public partial class formPodatelna : Form
    {
        public formPodatelna()
        {
            InitializeComponent();
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdPodania.ShowDialog();

            if (result == DialogResult.OK)
            {
                var path = fbdPodania.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(path);


                foreach (var file in dir.GetFiles("*.xml"))
                {
                    var xml = XDocument.Load(file.FullName);

                    var podanie = new Podanie();
                    string isValidResult = podanie.IsValid(xml,4);

                    rtbResults.AppendText(file.Name + " - " + isValidResult + "\n");
                }
            }
        }
    }
}

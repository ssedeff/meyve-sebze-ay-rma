using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meyve_ayirma
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            for(int i =0; i < lstTumu.Items.Count; i++)
            {
                if (lstTumu.Items[i].ToString() == "patates" ||
                    lstTumu.Items[i].ToString() == "soğan" ||
                    lstTumu.Items[i].ToString() == "ıspanak")
                {
                    lstSebze.Items.Add(lstTumu.Items[i]);
                }
                else
                {
                    lstMeyve.Items.Add(lstTumu.Items[i]);
                }
            }
        }
    }
}

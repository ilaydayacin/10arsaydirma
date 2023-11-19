using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listenin_içine_sırasıyla_sayı_ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            lbSaydir.Items.Clear();
            for (int i = 10; i < 120; i = i + 10)
            {
                lbSaydir.Items.Add(i);
            }
        }
    }
}

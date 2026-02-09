using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>(); 
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusilukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            if (e.KeyChar != (char)Keys.Escape)
            {
                return;
            }
            TyhjaaLomake();
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // jätä tyhjäksi tai lisää haluamasi toiminto
        }
    }
}

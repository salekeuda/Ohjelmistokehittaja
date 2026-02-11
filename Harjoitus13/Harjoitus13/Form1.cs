using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harjoitus13
{
    public partial class SuosikitFM : Form
    {
        public SuosikitFM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTB_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";
            vastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Temp\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Temp\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;

            foreach (string poika in pojat)
            {
                if (nimi == poika)
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }

            foreach (string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }
            if (vastausLB.Visible == false)
            {
                vastausLB.Text = "Nimesi ei ole suosittu, mene pois";
                vastausLB.Visible = true;
            }
        }
    }
}
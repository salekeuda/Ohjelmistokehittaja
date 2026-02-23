using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Harjoitus5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();

        public LukujenJarjestys()
        {
            InitializeComponent();
            this.KeyPreview = true;   // Mahdollistaa Enter/Escape‑näppäinten toiminnan
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ENTER painettu
            if (e.KeyChar == (char)Keys.Enter)
            {
                string syote = uusiLukuTB.Text.Trim();

                // Lopetus ja lajittelu
                if (syote == "-999")
                {
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);

                    VastausLB.Text = string.Join(" ", taulukko);
                    VastausLB.Visible = true;

                    jono.Clear();
                    uusiLukuTB.Text = "";
                    return;
                }
                Array.Sort(taulukko);

                MessageBox.Show("Listassa oli " + taulukko.Length + " lukua");

                VastausLB.Text = string.Join(" ", taulukko);

                // Normaali numeron lisäys
                if (int.TryParse(syote, out int luku))
                {
                    jono.Add(luku);
                    uusiLukuTB.Text = "";
                    VastausLB.Visible = false;
                }
                else
                {
                    MessageBox.Show("Syötä vain numeroita!");
                }
            }

            // ESC painettu
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }

        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ei toimintoa
        }
    }
}

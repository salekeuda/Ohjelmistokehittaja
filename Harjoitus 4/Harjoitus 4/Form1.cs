using System;
using System.Windows.Forms;

namespace Harjoitus_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime syntymaAika = SyntymaAikaDTP.Value;
            DateTime tanaan = DateTime.Now;

            // VUODET
            int vuodet = tanaan.Year - syntymaAika.Year;
            if (tanaan < syntymaAika.AddYears(vuodet))
                vuodet--;

            // PÄIVÄT
            int paivat = (tanaan - syntymaAika).Days;

            // TUNNIT, MINUUTIT, SEKUNNIT
            TimeSpan erotus = tanaan - syntymaAika;

            int tunnit = (int)erotus.TotalHours;
            int minuutit = (int)erotus.TotalMinutes;
            int sekunnit = (int)erotus.TotalSeconds;

            // KUUKAUDET (vuodet * 12 + kuluneet kuukaudet)
            int kuukaudet = vuodet * 12 + (tanaan.Month - syntymaAika.Month);
            if (tanaan.Day < syntymaAika.Day)
                kuukaudet--;

            // TULOSTUS LABELIIN
            VuodetLB.Text = $"{vuodet} vuotta";
            KuukaudetLB.Text = $"{kuukaudet} kuukautta";
            PaivatLB.Text = $"{paivat} päivää";
            TunnitLB.Text = $"{tunnit} tuntia";
            MinuutitLB.Text = $"{minuutit} minuuttia";
            SekunnitLB.Text = $"{sekunnit} sekuntia";
        }
    }
}

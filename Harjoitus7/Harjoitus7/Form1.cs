using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OtsikkoTB_Click(object sender, EventArgs e)
        {

        }

        private void KilsatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Laina, Nesteet, Vakuutus, Muut, Lopo, Pesu, Huolto, Renkaat, Kilsat, kustannukset;

            Laina = Convert.ToDouble(LainaTB.Text);
            Nesteet = Convert.ToDouble(NesteetTB.Text);
            Vakuutus = Convert.ToDouble(VakuutusTB.Text);
            Muut = Convert.ToDouble(MuutTB.Text);
            Lopo = Convert.ToDouble(LopoTB.Text);
            Pesu = Convert.ToDouble(PesuTB.Text);
            Huolto = Convert.ToDouble(HuoltoTB.Text);
            Renkaat = Convert.ToDouble(RenkaatTB.Text);
            Kilsat = Convert.ToDouble(KilsatCB.Text);
            kustannukset = (Laina + Nesteet + Vakuutus + Muut + Lopo + Pesu + Huolto + Renkaat) / (Kilsat / 12);
            VastausLB.Text = "Kustannukset kilometriä kohti ovat :" + kustannukset;
            VastausLB.Visible = true;
        }
    }
}

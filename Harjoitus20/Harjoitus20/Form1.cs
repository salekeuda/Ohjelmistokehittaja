using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            etunimiTB.Text = "";
            sukunimiTB.Text = "";
            puhelinTB.Text = "";
            spostiTB.Text = "";
            opiskelijanroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string etunimi = etunimiTB.Text = "";
            string sukunimi = sukunimiTB.Text = "";
            string puhelin = puhelinTB.Text = "";
            string email = spostiTB.Text = "";
            int opiskelijaNro = Int32.Parse (spostiTB.Text);

            if (etunimi.Trim().Equals("") || sukunimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || opiskelijaNro.Equals(""))
            {
                MessageBox.Show("Virhe - Vaaditut kentät - Etu- ja Sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(etunimi, sukunimi, puhelin, email, opiskelijaNro);
                if (lisaaAsiakas)
                {
             
                    
                        MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
            tietotauluDG.DataSource = opiskelija.haeOpiskelija();
        }
    }
}

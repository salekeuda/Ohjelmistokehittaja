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

namespace Harjoitus14
{
    public partial class paivakirjaFM : Form
    {
        public paivakirjaFM()
        {
            InitializeComponent();

            // Lue vanha päiväkirja ja näytä se tekstilaatikossa
            string teksti = File.ReadAllText("C:\\Temp\\paivakirja.txt");
            kirjaTB.Text = teksti;
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            // Luetaan nykyinen sisältö
            teksti += kirjaTB.Text;
           

            // Lisätään uusi merkintä + aikaleima
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + Environment.NewLine;

            // Tallennetaan tiedostoon
            TextWriter text = new StreamWriter("C:\\Temp\\paivakirja.txt");
            text.Write(teksti);
            text.Close();

            // Suljetaan ohjelma
            Application.Exit();
        }
    }
}


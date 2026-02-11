using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjoitus16
{
    
    public partial class Form1 : Form
    {
        private int kokonaisaika;
        public Form1()
        {
            InitializeComponent();
            stopBT.Enabled= false;
            for(int i=0; i <59; i++)
            {
                minuuttiCB.Items.Add(i.ToString());
                sekuntiCB.Items.Add(i.ToString());
            }
            minuuttiCB.SelectedIndex = 30;
            sekuntiCB.SelectedIndex= 0;
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false; 
            stopBT.Enabled = true;
            int minuutit = int.Parse(minuuttiCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekuntiCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTR.Enabled= true;   
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            stopBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTR.Enabled= false;
            aikaLB.Text = "00:00";
        }

        private void ajastinTR_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika/ 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                ajastinTR.Stop();
                MessageBox.Show("Aika loppu!");
            }
        }
    }
}

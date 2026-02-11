using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace harjoitus15
{
    public partial class sekkariFM : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public sekkariFM()
        {
            InitializeComponent();
        }

        

        private void kaynnistaBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
            //ajanottoTM.Start();
        }

        private void lopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
            //ajanottoTM.Stop();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
            //aikaLB.Text = "00:00:00.000";

        }

        private void sekkariFM_Load(object sender, EventArgs e)
        {

        }

        private void ajanottoTM_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}

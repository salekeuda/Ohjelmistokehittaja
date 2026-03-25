using System.Drawing.Text;

namespace harjoitus_12
{
    public partial class vastauslomakeForm : Form
    {
        int laskuri = 0;    
        int oikein = 0;
        string[] oikeatVastaukset = new string[] {"b", "d", "a", "a", "c", "a", "a", "b", "a", "c", "d"}; 
        string [] vastaukset = new string[10];

        public vastauslomakeForm()
        {
            InitializeComponent();
            vastausARB.CheckedChanged += new EventHandler(vastausARB_CheckedChanged);
            vastausBRB.CheckedChanged += new EventHandler(vastausARB_CheckedChanged);
            vastausCRB.CheckedChanged += new EventHandler(vastausARB_CheckedChanged);
            vastausDRB.CheckedChanged += new EventHandler(vastausARB_CheckedChanged);
        }

        private void vastauslomakeForm_Load(object sender, EventArgs e)
        {
             
        }
        private void vastausARB_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                kysymysLB.Text = "vastaus " + laskuri + ". kysymykseen";
            }
            else
            {
                vastausLB.Text = "";
                vastausARB.Enabled = false;
                vastausBRB.Enabled = false;
                vastausCRB.Enabled = false;
                vastausDRB.Enabled = false;
                for(int j = 0;  j < 10; j++)
                {
                    if (vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }  
                vastausLB.Text = "oikein vastattuja kysymyksiä: " + oikein + "/10";
                vastausLB.Visible = true;
              }
            tyhjaaVastaus();
        }
            private void tyhjaaVastaus()
        {
            if(vastausARB.Checked == true)
            {
                vastausARB.Checked = false;
                laskuri--;
            }
            if (vastausBRB.Checked == true)
            {
                vastausBRB.Checked = false;
                laskuri--;
            }
            if(vastausCRB.Checked == true)
            {
                vastausCRB.Checked = false;
                laskuri--;
            }
            if(vastausDRB.Checked == true)
            {
                vastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}

namespace harjoitus_10
{
    public partial class BMIform : Form
    {
        public BMIform()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0, BMI;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            BMI = Math.Round(paino / (pituus * pituus), 2);
            if (BMI < 18.5)
            {
                vastausLB.Text = "Painoindeksisi on; " + BMI;
                vastausLB.ForeColor = Color.Blue;
                kuvausLB.Text = "Olet alipainoinen";
                kuvausLB.ForeColor = Color.Blue;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
            else if (BMI < 25)
            {
                vastausLB.Text = "Painoindeksisi on; " + BMI;
                vastausLB.ForeColor = Color.Green;
                kuvausLB.Text = "normaalipaino";
                kuvausLB.ForeColor = Color.Green;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
            else if (BMI < 40)
            {
                vastausLB.Text = "Painoindeksisi on; " + BMI;
                vastausLB.ForeColor = Color.DarkOrange;
                kuvausLB.Text = "ylipaino";
                kuvausLB.ForeColor = Color.DarkOrange;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = "Painoindeksisi on; " + BMI;
                vastausLB.ForeColor = Color.Red;
                kuvausLB.Text = "huomattava ylipaino";
                kuvausLB.ForeColor = Color.Red;
                vastausLB.Visible = true;
                kuvausLB.Visible = true;
            }
        }
    }
}
 

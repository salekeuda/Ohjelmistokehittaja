namespace harjoitus_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            float luku1, luku2, vastaus;
            string merkki;
            luku1 = float.Parse(lukuiksiTB.Text); 
            luku2 = float.Parse(lukukaksiTB.Text);
            merkki = comboBox1.Text;
            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;  
                default:
                    vastaus = 0;
                    break;  
            }
            vastausLB.Text = Convert.ToString(vastaus);
            vastausLB.Visible = true;
        }
    }
}

namespace harjoitus_9
{
    public partial class AsteMuunninForm : Form
    {
        public AsteMuunninForm()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(asteetTB.Text);
            if (celciusRB.Checked)
            {
                vastaus = (asteet - 32) * 5 / 9;
                MessageBox.Show($"{asteet} F on {vastaus} C");

            }
            else if (fahreRB.Checked)
            {
                vastaus = asteet * 9 / 5 + 32;
                MessageBox.Show($"{asteet} C on {vastaus} F");
            }
        }
    }
}

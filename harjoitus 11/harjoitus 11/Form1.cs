namespace harjoitus_11
{
    public partial class nopaheittoForm : Form
    {
        public nopaheittoForm()
        {
            InitializeComponent();
        }

        private void heitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa1PB);
            piirraNoppa(noppa2PB);
        }
        private void piirraNoppa(PictureBox noppaBox) 
        {
            Random rnd = new Random();
            int noppaLuku = rnd.Next(1, 7); // Arvo luku 1-6
            // Piirrä noppa noppaBoxiin noppaLuku:n mukaan
            // Tämä on vain esimerkki, voit käyttää omia kuvia tai piirustuksia
            switch (noppaLuku)
            {
                case 1:
                    noppaBox.Image = Properties.Resources.dice01; // Oletetaan, että sinulla on kuvat nimeltä noppa1, noppa2, jne.
                    break;
                case 2:
                    noppaBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    noppaBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    noppaBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    noppaBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    noppaBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}

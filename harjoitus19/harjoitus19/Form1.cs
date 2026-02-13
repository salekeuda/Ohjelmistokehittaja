namespace harjoitus19
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent(GetMeistaBT1());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keuda oppilaskunnan kahvila palvelee luokassa 214 välitunnilla";
            meistaLB.Text += "\n\nKahvilasta saa ostaa mm. pullaa, keksejä, karkkia, mehua ja kahvia.";
            meistaLB.Text += "\n\nKahvilan tuotto käytetään oppilaskunnan toimintaan, kuten tapahtumiin ja retkiin.";
            meistaLB.Font = new Font("Arial", 12, FontStyle.Regular);
        }
    }
}

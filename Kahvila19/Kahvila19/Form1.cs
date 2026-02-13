namespace Kahvila19
{
    public partial class kahvilaFORM : Form
    {
        public kahvilaFORM()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kahvilaFORM_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Kahvila 19 on vuonna 2019 perustettu kahvila, joka sijaitsee Helsingin keskustassa. Tarjoamme laajan valikoiman erilaisia kahveja, teetä ja herkullisia leivonnaisia. Kahvilamme on tunnettu rennosta ilmapiiristään ja ystävällisestä palvelustaan. Tervetuloa nauttimaan hyvästä seurasta ja herkullisista juomista Kahvila 19:ssä!";
        }

        private void meistaBT_Click(object sender, EventArgs e)
        {

        }
    }
}

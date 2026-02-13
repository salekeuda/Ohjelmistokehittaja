namespace Laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            // tässä joudumme tekemään lukumuunnoksen tekstistä liukuluvuksi komennolla
            if (!float.TryParse(LukuYksiTB.Text, out float luku1))
            {
                MessageBox.Show("Invalid input in LukuYksiTB");
                return;
            }

            if (!float.TryParse(LukuKaksiTB.Text, out float luku2))
            {
                MessageBox.Show("Invalid input in LukuKaksiTB");
                return;
            }

            float vastaus = 0;
            string merkki = LaskutoimitusCB.Text;

            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                case "×":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                case "÷":
                    if (luku2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    vastaus = luku1 / luku2;
                    break;
                default:
                    MessageBox.Show("Unknown operation.");
                    return;
            }

            // If you have a UI control to show the result, set it here.
            // Example (uncomment if such control exists): VastausLB.Text = vastaus.ToString();
        }
    }
}

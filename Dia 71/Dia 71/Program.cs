namespace Dia_71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LaskeYhteen();
            //AsteenMuunnin();
            //PerusLasku();
            //JakoJaannos();
            //NimiPyynto();
            //Kertotaulu();
            ikakys();
        }

        static void LaskeYhteen()
        {
            int luku1, luku2;
            Console.Write("Anna ensimmäinen yhteenlaskettava kokonaisluku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen yhteenlaskettava kokonaisluku: ");
            luku2 = int.Parse(Console.ReadLine());
            laskeYhteen(luku1, luku2);
        }
        static void laskeYhteen(int eka, int toka)
        {
            Console.WriteLine(eka + "+" + toka + "=" + (eka + toka));
        }
        static void AsteenMuunnin()
        {
            int luku1;
            Console.Write("Anna celsius aste jonka haluat muuttaa fahrenheittemeksi: ");
            luku1 = int.Parse(Console.ReadLine());
            asteenMuunnin(luku1);
        }
        static void asteenMuunnin(int celsius)
        {
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(celsius + " C = " + fahrenheit + " F ");
        }
        static void PerusLasku()
        {
            int luku1, luku2;
            Console.Write("Anna ensimmäinen luku, joista haluat kaikki neljäperuslaskua: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku, joista haluat kaikki neljäperuslaskua: ");
            luku2 = int.Parse(Console.ReadLine());
            perus(luku1, luku2);
        }
        static void perus(int eka, int toka)
        {
            double plussa = eka + toka;
            double miinus = eka - toka;
            double kerro = eka * toka;
            double jaa = eka / toka;
            Console.WriteLine(plussa + "/" + miinus + "/" + kerro + "/" + jaa);
        }
        static void JakoJaannos()
        {
            int a, b;
            Console.Write("Anna ensimmäinen luku, josta haluat jakojäännöksen: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku, josta haluat jakojäännöksen: ");
            b = int.Parse(Console.ReadLine());
            jako(a, b);
            Console.WriteLine(a + "/" + b + "=" + jako(a, b));
        }
        static double jako(int a, int b)
        {
            return a % b;

        }
        static void NimiPyynto()
        {
            string a;
            Console.Write("Kerro nimesi tai muuten! ");
            a = (Console.ReadLine());
            Console.WriteLine("Hei " + nimi(a) + " tässä annettu käyttäjä. ");
        }
        static string nimi(string a)
        {
            return a;
        } // Lupa hypätä 6-9 tehtävät.
        static void Kertotaulu()
        {
            Console.WriteLine("Anna luku väliltä 1-10");
            int luku = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(luku + " x " + i + " = " + (luku * i));

            }  // Dia 72


        }
        static void ikakys()
        {
            string a;
            Console.Write("Kerro ikäsi: ");
            a = Console.ReadLine();
            Console.WriteLine(ika(a) + "- näytät ikäistäsi nuoremmalta.");
        }
        static string ika(string a)
        {
            return a;
        }
    }
}

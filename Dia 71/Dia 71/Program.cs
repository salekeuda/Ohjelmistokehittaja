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
            //ikakys();
            //luku();
            //KirjainVaihto(); 
            //PosiMi();
            //PiLa();
            Parittomat();
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
            for (int i = 1; i <= 10; i++)   // for silmukka
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
        static string ika(string a) // palauttaa merkkijonon
        {
            return a; // palauttaa käyttäjän syöttämän iän
        }

        static void luku()
        {
            Console.Write("Anna luku (10 tai suurempi): ");
            int luku = int.Parse(Console.ReadLine());

            if (luku < 10)
            {
                Console.WriteLine("Luvun piti olla isompi kuin 10");
                return; // Lopettaa metodin tähän
            }
            for (int i = 1; i < luku; i++) // i alkaa 1:stä ja jatkuu niin kauan kuin i on pienempi kuin luku
            {
                Console.Write(luku + " "); // "" ilman välilyöntiä tekee luvut yhteen
            }
        }
        static void KirjainVaihto()
        {
              Console.Write("Anna sana: ");
            string sana = Console.ReadLine();

            if (sana.Length < 2) // tarkistaa sanan pituuden 
            {
                Console.WriteLine("Sanan täytyy olla vähintään kaksi kirjainta pitkä.");
                return;
            }   
            char eka = sana[0];
            char vika = sana[sana.Length - 1]; // viimeinen kirjain
            string keskiosa = sana.Substring(1, sana.Length - 2); // keskiosa
            string uusi = vika + keskiosa + eka;
            Console.WriteLine("Uusi sana: " + uusi);
        }
        static void PosiMi()
        {
            Console.Write("Anna ensimmäinen luku: "); // pyytää käyttäjältä ensimmäisen luvun
            int luku1 = int.Parse(Console.ReadLine()); //   muuntaa syötteen kokonaisluvuksi
            Console.Write("Anna toinen luku: "); // pyytää käyttäjältä toisen luvun
            int luku2 = int.Parse(Console.ReadLine()); // muuntaa syötteen kokonaisluvuksi
            int tulos = luvut(luku1, luku2); // kutsutaan funktiota luvut
            if (tulos > 0) // tarkistaa onko tulos positiivinen
            {
                Console.WriteLine("Luvut ovat positiivisia.");
            }
            else if (tulos < 0)// tarkistaa onko tulos negatiivinen
            {
                Console.WriteLine("Luvut ovat negatiivisia.");
            }
            else// tarkistaa onko toinen luvuista positiivinen ja toinen negatiivinen
            {
                Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen."); // tulos on nolla
            }
        }

        static int luvut(int luku1, int luku2) // funktio joka palauttaa kahden luvun summan
        {
            return luku1 + luku2; // palauttaa lukujen summan
        }

        static void PiLa()
        {
            String str = "Tämä on esimerkki merkkijonosta.";
           
            string[] sana = str.Split(' '); // jakaa merkkijonon sanoiksi välilyönnin kohdalta
            string pisin = ""; // alustaa pisin-muuttujan tyhjäksi merkkijonoksi
            foreach (string s in sana) // käy läpi jokaisen sanan
            {
                if (s.Length > pisin.Length) // vertaa sanan pituutta pisin-muuttujan pituuteen
                {
                    pisin = s; // päivittää pisin-muuttujan, jos sana on pidempi
                }
            }
            Console.WriteLine(pisin); // tulostaa pisimmän sanan
        }
        static void Parittomat()
        {
            for (int i = 1; i <= 99; i += 3) //  lisää 2 parittomat tai 3 jos joka kolmas
            {
                Console.WriteLine(i); // tulostaa parittoman luvun
            }
        }
    }
}



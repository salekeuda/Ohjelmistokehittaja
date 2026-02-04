using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LumoTaulukko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tehtava1();
            //tehtava2();
            //tehtava3();
            //tehtava4();
            //tehtava5();
            //tehtava6();
            //tehtava7();
            //tehtava8();
            //tehtava9();
            //tehtava10();
            //tehtava11();
            //tehtava12();
            //tehtava13();
            //tehtava14();
            //tehtava15();
            //tehtava16();
            //tehtava17();
            //tehtava18();
            //tehtava19();
            tehtava20();
        }

        static void tehtava1()
        {
            string[] kauppalista = { "maito", "leipä", "juusto", "voi", "makkara" };

            for (int i = 0; i < kauppalista.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {kauppalista[i]}");
            }
        }

        static void tehtava2()
        {
            string[] nimet = new string[5];
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.Write($"Anna nimi {i + 1}/5: ");
                nimet[i] = Console.ReadLine();
            }
            Console.WriteLine("\nNimet ovat:");
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine(nimet[i]);
            }
        }

        static void tehtava3()
        {
            // Luo taulukko
            int[] taulukko = { 1, 2, 3, 4, 5 };

            // Laske taulukon pituus
            int pituus = taulukko.Length;

            // Tulosta pituus
            Console.WriteLine("Taulukon pituus on: " + pituus);
        }

        static void tehtava4()
        {
            // Use the generic List<string> (System.Collections.Generic)
            List<string> nimet = new List<string> { "Matti", "Teppo", "Jussi", "Kalle", "Pekka" };
            nimet.Add("Antti");
            Console.WriteLine("Nimet ovat:");
            foreach (string nimi in nimet)
            {
                Console.WriteLine(nimi);
            }
        }
        static void tehtava5()
        {
            int[] t1 = { 1, 2, 3 };
            int[] t2 = { 4, 5, 6 };
            int[] y = t1.Concat(t2).ToArray();

            Console.WriteLine("Yhdistetty taulukko:");
            foreach (int i in y)
            {
                Console.WriteLine(i);
            }
        }
        static void tehtava6()
        {
            // Alkuperäinen taulukko
            int[] alkuperainen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Suodata parilliset numerot LINQ:n avulla
            int[] parilliset = alkuperainen.Where(numero => numero % 2 == 0).ToArray();

            // Tulosta uusi taulukko
            Console.WriteLine("Parilliset numerot:");
            foreach (int numero in parilliset)
            {
                Console.WriteLine(numero);
            }
        }
        static void tehtava7()
        {
            // Alkuperäinen taulukko
            int[] taulukko = { 5, 2, 9, 1, 5, 8, 3 };

            // Lajittele taulukko
            Array.Sort(taulukko);

            // Tulosta lajiteltu taulukko
            Console.WriteLine("Lajiteltu taulukko:");
            foreach (int numero in taulukko)
            {
                Console.WriteLine(numero);
            }
        }
        static void tehtava8()
        {
            // Alkuperäinen taulukko
            int[] taulukko = { 1, 2, 3, 4, 5 };

            // Käännä taulukko
            Array.Reverse(taulukko);

            // Tulosta käännetty taulukko
            Console.WriteLine("Käännetty taulukko:");
            foreach (int numero in taulukko)
            {
                Console.WriteLine(numero);
            }
        }
        static void tehtava9()
        {

            string[] nimet = { "Matti", "Anna", "Eeva" }; // Alkuperäinen taulukko


            string merkkijono = string.Join(", ", nimet); // Muuta taulukko merkkijonoksi


            Console.WriteLine("Taulukko merkkijonona:"); // Tulosta merkkijono
            Console.WriteLine(merkkijono);
        }
        static void tehtava10()
        {
            // Alkuperäinen lista
            List<int> numerot = new List<int> { 1, 2, 3, 4, 5 };

            // Poista kolmas alkio (indeksi 2)
            numerot.RemoveAt(2);

            // Tulosta päivitetty lista
            Console.WriteLine("Taulukko ilman kolmatta alkiota:");
            foreach (int numero in numerot)
            {
                Console.WriteLine(numero);
            }
        }
        static void tehtava11()
        {
            int[] numerot = { 1, 2, 3, 4, 5 };

            // Haettava arvo
            int haettava = 3;

            // Etsi indeksin sijainti
            int indeksi = Array.IndexOf(numerot, haettava);

            // Tarkista löytyikö alkio
            if (indeksi != -1)
            {
                Console.WriteLine($"Alkio {haettava} löytyi indeksistä {indeksi}.");
            }
            else
            {
                Console.WriteLine($"Alkiota {haettava} ei löytynyt taulukosta.");
            }
        }
        static void tehtava12()
        {
            int[] alkuperainen = { 1, 2, 3, 4, 5 };

            // Kopioi kaksi viimeistä alkiota
            int[] kaksiViimeista = new int[2];
            Array.Copy(alkuperainen, alkuperainen.Length - 2, kaksiViimeista, 0, 2);

            // Tulosta uusi taulukko
            Console.WriteLine("Uusi taulukko (kaksi viimeistä alkiota):");
            foreach (int numero in kaksiViimeista)
            {
                Console.WriteLine(numero);
            }
        }
        static void tehtava13()
        {
            // Alkuperäinen taulukko
            string[] sanat = { "omena", "banaani", "appelsiini", "kiivi" };
            // Muuta kaikki sanat isoiksi kirjaimiksi
            for (int i = 0; i < sanat.Length; i++)
            {
                sanat[i] = sanat[i].ToUpper();
            }
            // Tulosta muokattu taulukko
            Console.WriteLine("Sanat isoina kirjaimina:");
            foreach (string sana in sanat)
            {
                Console.WriteLine(sana);
            }
        }
        static void tehtava14()
        {
            int[] numerot = { 1, 2, 3, 4, 5 };

            int summa = 0;

            for (int i = 0; i < numerot.Length; i++)
            {
                summa += numerot[i];
            }

            Console.WriteLine($"Taulukon summa on: {summa}");
        }
        static void tehtava15()
        {
            int[] numerot = { 1, 2, 3, 4, 5 };

            int summa = 0;

            for (int i = 0; i < numerot.Length; i++)
            {
                summa += numerot[i];
            }

            double keskiarvo = (double)summa / numerot.Length;

            Console.WriteLine($"Taulukon keskiarvo on: {keskiarvo}");
        }
        static void tehtava16()
        {
            int[] alkuperainen = { 1, 2, 3 };

            // Uuden taulukon koko = alkuperäinen pituus * 3
            int[] uusi = new int[alkuperainen.Length * 3];

            int index = 0;

            // Kopioidaan alkuperäinen taulukko kolme kertaa
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < alkuperainen.Length; i++)
                {
                    uusi[index] = alkuperainen[i];
                    index++;
                }
            }

            // Tulostetaan uusi taulukko
            Console.WriteLine("Uusi taulukko:");
            foreach (int numero in uusi)
            {
                Console.Write(numero + " ");
            }
        }
        static void tehtava17()
        {
            int[] alkuperainen = { 1, 2, 2, 3, 4, 4, 5 };

            List<int> uniikit = new List<int>();

            foreach (int numero in alkuperainen)
            {
                if (!uniikit.Contains(numero))
                {
                    uniikit.Add(numero);
                }
            }

            Console.WriteLine("Uniikit arvot:");
            foreach (int n in uniikit)
            {
                Console.Write(n + " ");
            }
        }
        static void tehtava18()
        {
            int[] numerot = { 1, 2, 3, 4, 5 };

            // Vaihdetaan ensimmäinen ja viimeinen alkio
            int temp = numerot[0];
            numerot[0] = numerot[numerot.Length - 1];
            numerot[numerot.Length - 1] = temp;

            // Tulostetaan taulukko
            Console.WriteLine("Taulukko vaihdon jälkeen:");
            foreach (int n in numerot) 
            {
                Console.Write(n + " ");
            }
        }
        static void tehtava19()
        {
            string[] nimet = { "Matti", "Anna", "Eeva" };

            for (int i = 0; i < nimet.Length; i++)
            {
                nimet[i] = nimet[i].ToUpper();
            }

            Console.WriteLine("Nimet isoilla kirjaimilla:");
            foreach (string nimi in nimet)
            {
                Console.WriteLine(nimi);
            }
        }
        static void tehtava20()
        {
            int[] numerot = { 1, 2, 3, 4, 5 };

            List<int> uudet = new List<int>();

            foreach (int n in numerot)
            {
                if (n >= 4)
                {
                    uudet.Add(n);
                }
            }

            Console.WriteLine("Taulukko ilman neljää pienempiä numeroita:");
            foreach (int n in uudet)
            {
                Console.Write(n + " ");
            }
        }
    }
}


using System;

// Pseudocode:
// 1. Prompt the user for an integer whose factorial (kertoma) will be computed.
// 2. Read input as string from Console.
// 3. Attempt to parse the string to an int using int.TryParse.
//    - If parsing fails, print an error and return from the method.
// 4. If the parsed integer is negative, print a message and return (factorial undefined).
// 5. Compute factorial with a loop from 1 to luku inclusive, using a long to reduce overflow risk.
// 6. Print the result.
// 7. Keep tehtava1 behavior unchanged.

class Program
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
        tehtava16();

    }
    static void tehtava1()
    {
        int laina = 5000;
        int lainaAika = 2;
        double korko = 0.02;
        double korkosumma = 0;
        double maksettava = 0;
        maksettava = laina;
        for (int i = 0; i < lainaAika; i++)
        {
            maksettava += maksettava * korko;
        }
        korkosumma = maksettava - laina;
        maksettava = laina + korkosumma;
        Console.WriteLine("Maksettavaa tulee {0} + {1} = {2}", laina, korkosumma, maksettava);
    }
    static void tehtava2()
    {
        Console.Write("Anna luku, josta lasketaan kertoma: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int luku))
        {
            Console.WriteLine("Virhe: syöte ei ole kelvollinen kokonaisluku.");
            return;
        }
        if (luku < 0)
        {
            Console.WriteLine("Negatiivisen luvun kertoma ei ole määritelty.");
            return;
        }
        long kertoma = 1;
        for (int i = 1; i <= luku; i++)
        {
            kertoma *= i;
        }
        Console.WriteLine("Luvun {0} kertoma on {1}", luku, kertoma);
    }
    static void tehtava3()
    {
        int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
        int luku = 3;
        for (int i = 0; i < taulukko.Length; i++)
        {
            if (luku == taulukko[i])
            {
                Console.WriteLine("Ensimmäinen esiintymä luvulle {0} on kohdassa {1}.", luku, i);
                break;
            }
        }
        static void tehtava4()
        {
            string sana;
            Console.Write("Anna käännettävä sana: ");
            sana = Console.ReadLine();
            for (int i = sana.Length; i > 0; i--)
            {
                Console.Write(sana[i - 1]);
            }
        }
        static void tehtava5()
        {
            int[] talukko = new int[] { 6, 7, 2, 4, 3, 8, 1 };
            int maksimi = 0;
            for (int i = 0; i < talukko.Length; i++)
            {
                if (talukko[i] > maksimi)
                {
                    maksimi = talukko[i];
                }
            }
            Console.Write("Taulukon [ ");
            foreach (int arvo in talukko)
            {
                Console.Write("{0} ", arvo);
            }
            Console.WriteLine("] maksimiarvo on {0}", maksimi);
        }
        static void tehtava6()
        {
            int[] tallukko = new int[] { 6, 7, 2, 4, 3, 8, 1 };
            int yhteensa = 0;
            float keskiarvo;
            for (int i = 0; i < tallukko.Length; i++)
            {
                yhteensa += tallukko[i];
            }
            keskiarvo = (float)yhteensa / tallukko.Length;
            Console.Write("Taulukon [ ");
            foreach (int arvo in tallukko)
            {
                Console.Write("{0} ", arvo);
            }
            Console.WriteLine("] keskiarvo on {0}", keskiarvo);
        }
        static void tehtava7()
        {
            string[] taulu = new string[] { "a", "b", "c", "d", "e", "f" };
            string[] isot = new string[6];
            for (int i = 0; i < taulu.Length; i++)
            {
                isot[i] = taulu[i].ToUpper();
            }
            Console.Write("Taulukon kirjaimet isoina: [ ");
            foreach (string arvo in isot)
            {
                Console.Write("{0} ", arvo);
            }
            Console.WriteLine("]");
        }
      
                }  static void tehtava8()
        {
            int[] taulukko = { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
            int laskuri = 0;

            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] % 2 != 0) // pariton
                {
                    laskuri++;

                    if (laskuri == 7)
                    {
                        Console.WriteLine($"Taulukon 7. pariton luku on: {taulukko[i]}");
                        break; // ei tarvitse jatkaa
                    }
            }
             
        }  
    } static void tehtava9()
            {
        int[] taulukko = new int[] { 6, 7, 2, 4, 3, 8, 1, 9, 0, 3, 5, 7, 3, 6, 8, 2, 4, 3 };
        Array.Sort(taulukko);
        int pituus;
        pituus = taulukko.Length;
        Console.WriteLine("Toiseksi suurin arvo on {0}", taulukko[pituus - 2]);
    }
    static void tehtava10()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("viisitoista ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("viisi ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("kolme ");
            }
            else
            {
                Console.Write("{0} ", i);
            }
        }
        } static void tehtava11()
    {
        int[] fibo = new int[10];
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < 10; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        Console.Write("Fibonaccin numerot ovat: [");
        for (int j = 0; j < 10; j++)
        {
            if (j < 9)
            {
                Console.Write("{0}, ", fibo[j]);
            }
            else
            {
                Console.Write("{0}]", fibo[j]);
            }
        }
        
    }
    static void tehtava12()
        {
        Console.Write("Anna tarkastettava sana / lause: ");
        string tarkasta = Console.ReadLine();
        char[] kaannettava = tarkasta.ToCharArray();
        Array.Reverse(kaannettava);
        string kaannetty = new string(kaannettava);
        Console.WriteLine(kaannetty);
        if (tarkasta == kaannetty)
        {
            Console.Write("Sana / lause on palidromi");
        }
        else
        {
            Console.Write("Sana / lause ei ole palidromi");
        }
    }
    static void tehtava13()
    {
        int[] fibo = new int[10];
        int summa = 0;
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < 10; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        Console.Write("Fibonaccin numerot ovat: [");
        for (int j = 0; j < 10; j++)
        {
            if (fibo[j] % 2 == 0)
            {
                summa += fibo[j];
            }
        }
        Console.WriteLine("Parillisten Fibonaccin lukujen summa on {0}", summa);
    }
    static void tehtava14()
    {
        int[] fibo = new int[10];
        int summa = 0;
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < 10; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        Console.Write("Fibonaccin numerot ovat: [");
        for (int j = 0; j < 10; j++)
        {
            if (fibo[j] % 2 != 0)
            {
                summa += fibo[j];
            }
        }
        Console.WriteLine("Parittomien Fibonaccin lukujen summa on {0}", summa);
    }
    static void tehtava15()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int eka, toka, temp;
        Console.Write("Anna isompi muuttuja: ");
        eka = Int32.Parse(Console.ReadLine());
        Console.Write("Anna pienempi muuttuja: ");
        toka = Int32.Parse(Console.ReadLine());
        while (toka != 0)
        {
            Console.WriteLine(toka);
            temp = toka;
            toka = eka % toka;
            eka = temp;
        }
        Console.WriteLine("Muuttujien suurin yhteinen nimittäjä on {0}", eka);
    }
    static void tehtava16()
    {
        static void Main(string[] args)
        {
            Console.Write("Anna joukko numeroita pilkulla erotettuna: ");
            string joukko = Console.ReadLine();
            string[] taulu = joukko.Split(",");
            foreach (string x in taulu)
            {
                Console.Write(" {0}", x);
            }
        }
    }
}









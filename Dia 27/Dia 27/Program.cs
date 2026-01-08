namespace Dia_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LuvutJarjestyksessa();
            //Suurinkolmesta();
            //LukuSanana();
            //SuurinViidesta();
            //SyotettavaTieto();
            //BonusPisteet();
            NumerotSanoiksi();
        }
        static void LuvutJarjestyksessa() {
            Console.WriteLine("Anna luku");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            int luku2 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                int temp = luku1;
                luku1 = luku2;
                luku2 = temp;
            }
            Console.WriteLine(luku1 + " " + luku2);
        }
        static void Suurinkolmesta()
        {
            Console.Write("Anna 1. luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna 3. luku: ");
            int luku3 = int.Parse(Console.ReadLine());
            int suurin;
            if (luku1 > luku2 && luku1 > luku3)
            {
                suurin = luku1;
            }
            else if (luku2 > luku3)
            {
                suurin = luku2;
            }
            else { suurin = luku3; }
            Console.WriteLine("Suurin luku oli: " + suurin);


        }
        static void LukuSanana()
        {
            Console.Write(" Anna luku 0-9 välillä: ");
            int numerotSanaksi = int.Parse(Console.ReadLine());
            switch (numerotSanaksi)
            {
                case 0: Console.WriteLine("Nolla");
                    break;
                case 1: Console.WriteLine("Yksi");
                    break;
                case 2: Console.WriteLine("Kaksi");
                    break;
                case 3: Console.WriteLine("Kolme");
                    break;
                case 4: Console.WriteLine("Neljä");
                    break;
                case 5:
                    Console.WriteLine("Viisi");
                    break;
                case 6:
                    Console.WriteLine("Kuusi");
                    break;
                case 7:
                    Console.WriteLine("Seitsemän");
                    break;
                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;
                default: Console.WriteLine("Luku ei ole välillä 0-9");
                    break;
            }

        }
        static void SuurinViidesta()
        {
            int[] luvut = new int[5];
            Console.Write("Anna 1. luku: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. luku: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna 3. luku: ");
            luvut[2] = int.Parse(Console.ReadLine());
            Console.Write("Anna 4. luku: ");
            luvut[3] = int.Parse(Console.ReadLine());
            Console.Write("Anna 5. luku: ");
            luvut[4] = int.Parse(Console.ReadLine());

            Array.Sort(luvut);
            Console.WriteLine("Suurin luku on: " + luvut[4]);
        }

        static void SyotettavaTieto()
        {
            Console.Write("Anna syötettävä tieto (i=kokonaisluku, d=double, m=merkkijono): ");
            string tieto = Console.ReadLine();
            Console.Write("Anna syötettävä arvo (numero tai merkkijono): ");
            string arvo = Console.ReadLine();
            switch (tieto)
            {
                case "i":
                    int iluku = int.Parse(arvo);
                    Console.WriteLine(iluku + 1);
                    break;
                case "d":
                    double dluku = double.Parse(arvo);
                    Console.WriteLine(dluku + 1);
                    break;
                case "m":
                    Console.WriteLine(arvo + "*");
                    break;
                default:
                    Console.WriteLine("Et antanut oikeaa valintaa (i, d, m,)!");
                    break;
            }

        }
        static void BonusPisteet()
        {
            try
            {
                Console.Write("Ole hyvä ja anna bonuspisteesi välillä 1-9: ");
                int bonus = int.Parse(Console.ReadLine());

                switch (bonus)
                {
                    case 1:
                    case 2:
                    case 3:
                        bonus *= 10;
                        break;

                    case 4:
                    case 5:
                    case 6:
                        bonus *= 100;
                        break;

                    case 7:
                    case 8:
                    case 9:
                        bonus *= 1000;
                        break;

                    default:
                        Console.WriteLine("VIRHE! Lukusi tulee olla välillä 1-9");
                        return;
                }

                Console.WriteLine("Bonuspisteet: " + bonus);
            }
            catch (FormatException)
            {
                Console.WriteLine("Virheellinen syöte: syötä numero.");
            }
                             
        }
        static void NumerotSanoiksi()
        {
            Console.Write("Anna numero: ");
            int number = int.Parse(Console.ReadLine());

            string tulos = NumerotSanoiksi(number);
            Console.WriteLine("Sanana: " + tulos);
        }

        static string NumerotSanoiksi(int number)
        {
            if (number == 0)
                return "nolla";

            if (number < 0)
                return "miinus " + NumerotSanoiksi(Math.Abs(number));

            string words = "";


            if ((number / 100) > 0)
            {
                words += NumerotSanoiksi(number / 100) + "sataa";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "ja ";

                var unitsMap = new[] { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän", "kymmenen", "yksitoista", "kaksitoista", "kolmetoista", "neljätoista", "viisitoista", "kuusitoista", "seitsämäntoista", "kahdeksantoista", "yhdeksäntoista" };
                var tensMap = new[] { "nolla", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}










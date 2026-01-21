namespace LumoAkatemiaPerus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
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
            //tehtava16(); 
            //tehtava17();
            tehtava18();
        }
        static void tehtava2()
        {
            Console.WriteLine("Anna luku jonka halua + ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku jonka haluat + ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(y + x);
        }
        static void tehtava3()
        {
            Console.WriteLine("Anna luku jonka halua - ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku jonka haluat - ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(y - x);
        }
        static void tehtava4()
        {
            Console.WriteLine("Anna luku jonka halua * ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(y * x);
        }
        static void tehtava5()
        {
            Console.WriteLine("Anna luku jonka halua / ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(y / x);
        }
        static void tehtava6()
        {

            Console.Write("Anna celsius aste jonka haluat muuttaa fahrenheitiksi ");
            int y = int.Parse(Console.ReadLine());
            double x = (double)(y * 1.8 + 32);

            Console.WriteLine(x + "f");
        }
        static void tehtava7()
        {

            Console.Write("Anna fahrenheit aste jonka haluat tietää celcius asteena ");
            int y = int.Parse(Console.ReadLine());
            double x = (y - 32) / 1.8;

            Console.WriteLine(x + "c");
        }
        static void tehtava8()
        {

            Console.Write("Anna maili jonka haluat tietää kilometreinä ");
            int y = int.Parse(Console.ReadLine());
            double x = y * 1.6;

            Console.WriteLine(x + "km");
        }
        static void tehtava9()
        {

            Console.Write("Anna kilometrit jonka haluat tietää maileina ");
            int y = int.Parse(Console.ReadLine());
            double x = y / 1.6;

            Console.WriteLine(x + "Mailia");
        }
        static void tehtava10()
        {

            Console.Write("Anna inch jonka haluat tietää cm ");
            int y = int.Parse(Console.ReadLine());
            double x = y * 2.54;

            Console.WriteLine(x + "cm");
        }
        static void tehtava11()
        {

            Console.Write("Anna cm jonka haluat tietää inch ");
            int y = int.Parse(Console.ReadLine());
            double x = y / 2.54;

            Console.WriteLine(x + "inch");
        }
        static void tehtava12()
        {

            Console.Write("Anna jaardi jonka haluat tietää metreinä ");
            int y = int.Parse(Console.ReadLine());
            double x = y * 0.9144;

            Console.WriteLine(x + "m");
        }
        static void tehtava13()
        {

            Console.Write("Anna metrit jonka haluat tietää jaardeina ");
            int y = int.Parse(Console.ReadLine());
            double x = y / 0.9144;

            Console.WriteLine(x + "jaardia");
        }
        static void tehtava15()
        {

            Console.Write("Anna ympyrän säde ");
            double r = double.Parse(Console.ReadLine());
            double ala = Math.PI * r * r;
            Console.WriteLine("Ympyrän ala on " + ala);
        }
        static void tehtava16()
        {

            Console.Write("Anna neliön sivu ");
            double s = double.Parse(Console.ReadLine()); // pyytää käyttäjää syöttämään neliön sivun pituuden
            double ala = s * s; // laskee neliön pinta-alan
            Console.WriteLine("Pinta-ala = " + ala); // näyttää neliön pinta-alan
        }
        static void tehtava17()
        {
            Console.Write("Anna suorakulmion pituus ");
            double p = double.Parse(Console.ReadLine()); // pyytää käyttäjää syöttämään suorakulmion pituuden
            Console.Write("Anna suorakulmion leveys "); // pyytää käyttäjää syöttämään suorakulmion leveyden
            double l = double.Parse(Console.ReadLine()); // lukee käyttäjältä suorakulmion leveyden
            double ala = p * l; // laskee suorakulmion pinta-alan
            Console.WriteLine("Pinta-ala = " + ala); // näyttää suorakulmion pinta-alan
        }
        static void tehtava18() 
        {
            Console.Write("Anna päivien määrä: "); 
            double paivat = double.Parse(Console.ReadLine()); // lukee käyttäjältä päivien määrän
            double vuodet =Math.Ceiling( paivat / 365.25 - (paivat % 365.25) / 365.25); // laskee vuodet kokonaislukuina math.Ceiling avulla pyöristää ylöspäin
            paivat = paivat - (int)(365.25 * vuodet); // vähentää vuodet päivistä
            double kuukaudet = (int) (paivat / 30.44); // laskee kuukaudet kokonaislukuina
            double paiva = paivat - (int)(30.44 * kuukaudet);// vähentää kuukaudet päivistä
            Console.WriteLine("Vuosia: " + vuodet + " Kuukausia: " + kuukaudet + " Päiviä: " + paiva); 
        }
    }
}
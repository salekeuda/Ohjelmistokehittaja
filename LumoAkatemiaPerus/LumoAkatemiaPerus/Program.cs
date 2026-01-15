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
            tehtava10();

        }
        static void tehtava2()
        {
            Console.WriteLine("Anna luku jonka halua + ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku jonka haluat + ");
            int x = int.Parse(Console.ReadLine());  
            Console.WriteLine(y+x);
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
            Console.WriteLine( y / x );
        }
        static void tehtava6()
        {
            
            Console.Write("Anna celsius aste jonka haluat muuttaa fahrenheitiksi ");
            int y = int.Parse(Console.ReadLine());
            double x = (double) (y * 1.8 + 32); 
            
            Console.WriteLine(x + "f");
        }
        static void tehtava7()
        {

            Console.Write("Anna fahrenheit aste jonka haluat tietää celcius asteena ");
            int y = int.Parse(Console.ReadLine());
            double x =(y -32) / 1.8;

            Console.WriteLine(x + "c");
        }
        static void tehtava8()
        {

            Console.Write("Anna maili jonka haluat tietää kilometreinä ");
            int y = int.Parse(Console.ReadLine());
            double x = y * 1.6 ;

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
    }
}
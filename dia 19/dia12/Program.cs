namespace dia19

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tehtava1();
            //Tehtava2();
            //Tehtava3();
            //Tehtava4();
            //Tehtava5();
            //Tehtava6();
            //Tehtava7();
            //Tehtava8();
            Tehtava9();
        }
        static void Tehtava1()
        {
            Console.WriteLine("Hei anna y:n arvo esim 5: ");
            int y = int.Parse(Console.ReadLine());
            int x = y + 3;
            Console.Write("x = " + x);
        }
        static void Tehtava2()
        {
            Console.WriteLine("Hei anna y:n arvo esim 5: ");
            int y = int.Parse(Console.ReadLine());
            int x = y - 2;
            Console.Write("x = " + x);
        }
        static void Tehtava3()
        {
            Console.WriteLine("Hei anna y:n arvo esim 5: ");
            int y = int.Parse(Console.ReadLine());
            int x = y * 5;
            Console.Write("x = " + x);
        }
        static void Tehtava4()
        {
            Console.Write("Hei anna x:n arvo esim 10: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Hei anna y:n arvo esim 5: ");
            int y = int.Parse(Console.ReadLine());
            x = x / y;
            Console.Write("x = " + x);
        }
        static void Tehtava5() //Jakojäännös %
        {
            Console.Write("Hei anna x:n arvo esim 24: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Hei anna y:n arvo esim 5: ");
            int y = int.Parse(Console.ReadLine());
            x = x % y;
            Console.Write("x = " + x);
        }
        static void Tehtava6()
        {
            Console.Write("Hei anna x:n arvo esim 10: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Hei anna y:n arvo esim 5: ");
            int y = int.Parse(Console.ReadLine());
            x = x + y;
            Console.Write("x = " + x);
        }
        static void Tehtava7()
        {
            Console.Write("Hei anna x:n arvo esim 10: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Hei anna y:n arvo esim 5: ");
            int y = int.Parse(Console.ReadLine());
            x = x - y;
            Console.Write("x = " + x);
        }
        static void Tehtava8()
        {
            Console.Write("Anna x esim 10: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Anna y esim 5: ");
            int y = int.Parse(Console.ReadLine());
            x = x * y;
            Console.Write("x = " + x);
        }
        static void Tehtava9()
        {
            Console.Write("Anna x esim 10: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Anna y esim 5: ");
            int y = int.Parse(Console.ReadLine());
            x = x / y;
            Console.Write("x = " + x);
        }

    }
}
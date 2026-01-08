namespace Yksinumerot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna y:n arvo: ");
           string y  = Console.ReadLine();
            int x = 3;
            int uusiy = int.Parse(y);
            Console.WriteLine("Tulos on = " + (x+uusiy));
        }
    }
}
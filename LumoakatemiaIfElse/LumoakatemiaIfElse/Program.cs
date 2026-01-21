namespace LumoakatemiaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuurinLuku();
        }
        static void SuurinLuku()
        {
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            int eka = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            int toka = int.Parse(Console.ReadLine());
            if (eka > toka)
            {
                Console.WriteLine("{0} on suurempi kuin {1}", eka, toka);
            }
            else
            {
                Console.WriteLine("{0} on suurempi kuin {1}", toka, eka);
            }
          }
        
    }
}
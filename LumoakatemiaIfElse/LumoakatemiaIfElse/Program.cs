namespace LumoakatemiaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SuurinLuku();
            //SuurinKolmesta();
            tehtava3();
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
        static void SuurinKolmesta()
        {
            int[] luvut = new int[3];
            Console.Write("Anna ensimmäinen kokonaisluku: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas kokonaisluku: ");
            luvut[2] = int.Parse(Console.ReadLine());
            Array.Sort(luvut);
            Console.Write("Luvut järjestyksessä: ");
            foreach (int x in luvut)
            {
                Console.Write("{0} ", x);
            }
        }
        static void tehtava3()
        {

        }
    }
}
namespace Dia_71
{
    internal static class ProgramHelpers
    {
        static void PosiMi()
        {
            Console.Write("Anna luku: ");
            int luku = int.Parse(Console.ReadLine());
            if (luku > 0)
            {
                Console.WriteLine("Luku on positiivinen.");
            }
            else if (luku < 0)
            {
                Console.WriteLine("Luku on negatiivinen.");
            }
            else
            {
                Console.WriteLine("Luku on nolla.");
            }
        }
    }
}
namespace METHODS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountToTen();
            Count(11);
            void CountToTen()
            {
                for (int current = 1; current <= 10; current++)
                    Console.WriteLine(current);
            }
            void Count(int numberToCountTo)
            {
                for (int current = 1; current <= numberToCountTo; current++)
                    Console.WriteLine(current);
            }
        }
    }
}

namespace METHODS
{
    internal class Program  // Métodos = una forma de dividir problemas grandes
                            //Cada método resuelve un problema pequeño
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
            string GetUserName()
            {
                while (true)
                {
                    Console.Write("What is your name? ");
                    string name = Console.ReadLine();
                    if (name != "") // Empty string
                        return name;
                    Console.WriteLine("Let's try that again.");
                }
            }
        }
    }
}

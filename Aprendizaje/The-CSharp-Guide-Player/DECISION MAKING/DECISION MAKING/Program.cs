namespace DECISION_MAKING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 100;
            if (score == 100) // sin llaves el programa solo interpreta a la primera linea como parte de la condicion if
                Console.WriteLine("A+!");
                 Console.WriteLine("Perfect score!"); // BUG!
        }
    }
}

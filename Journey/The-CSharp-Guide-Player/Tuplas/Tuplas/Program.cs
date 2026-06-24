namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayScore("Hola", 777, 666);
            string[] names = new string[3] { "R2-D2", "C-3PO", "GONK" };
            int[] points = new int[3] { 12420, 8543, -1 };
            int[] level = new int[3] { 15, 9, 1 };
           // (string, int, int) score = ("R2-D2", 12420, 15);
            var score1 = ("R2-D2", 12420, 15);
           // Console.WriteLine($"Name:{score.Item1} Level:{score.Item3} Score:{score.Item2}");
            void DisplayScore((string Name, int Points, int Level) score)
            {
                Console.WriteLine(
                $"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
            }
        }
    }
}

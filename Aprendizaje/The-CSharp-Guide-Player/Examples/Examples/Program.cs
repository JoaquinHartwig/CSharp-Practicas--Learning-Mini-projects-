namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue; // Start higher than anything in the array.
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < currentSmallest)
                    currentSmallest = array[index];
            }
            Console.WriteLine(currentSmallest);
        }
    }
}

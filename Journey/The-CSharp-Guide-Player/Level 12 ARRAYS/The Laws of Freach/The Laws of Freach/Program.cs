namespace The_Laws_of_Freach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            for (int index = 0; index < array.Length; index++)
                total += array[index];
            float average = (float)total / array.Length;
            Console.WriteLine(average);


            int total2 = 0;

            foreach (int index in array)
            {
                total2 += index;
                

            }
            float average2 = (float)total2 / array.Length;
            Console.WriteLine(average2);

        }
    }
}

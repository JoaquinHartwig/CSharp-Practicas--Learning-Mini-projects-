namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Objectives:
 • Make a program that creates an array of length 5.
 • Ask the user for five numbers and put them in the array.
 • Make a second array of length 5.
 • Use a loop to copy the values out of the original array and into the new one.
 • Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
 again.*/

           
            int[] array = new int[5]; //create the array of 5 positions
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write( $" {i +1}  Enter a number for array:");
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
               


            }
           
            
            int[] array2 = new int[5];
            for (int i = 0;i < array2.Length; i++)
            {
                array2[i] = array[i];


            }
            Console.WriteLine("he_Replicator_of_D_To");
            Console.WriteLine("Array 1:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Array 2:");

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}

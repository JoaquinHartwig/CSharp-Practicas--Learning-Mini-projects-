namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArary = { 1, 2, 3 };
            string[] stringArary = { "1", "2", "3" };
            MostrarArreglos(intArray); 
            MostrarArreglos(doubleArary);
            MostrarArreglos(stringArary);



        }
        public static void MostrarArreglos<Alex>(Alex[] arreglo)
        {
            foreach (Alex i in arreglo)
            {

                Console.Write(i + " ");

            }
            Console.WriteLine();

        }
    }
}

namespace The_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Empieza Main");

                Method1();

                Console.WriteLine("Termina Main");
            

            static void Method1()
            {
                Console.WriteLine("Empieza Method1");

                Method2();

                Console.WriteLine("Termina Method1");
            }

            static void Method2()
            {
                Console.WriteLine("Estoy en Method2");
            }
        }
    }
}

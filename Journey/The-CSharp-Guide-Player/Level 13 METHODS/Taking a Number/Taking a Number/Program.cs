namespace Taking_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int edad = AskForNumber("Enter your age:");
            int Result = AskForNumber("100000");
           
            Console.WriteLine($"The answer is {Result}");
            AskForNumberInRange("Joaquin", 1, 100);






            int AskForNumber(string text)
            {
                Console.WriteLine("What is the airspeed velocity of an unladen swallow ?");
                Console.WriteLine(text);
                int age = Convert.ToInt32(Console.ReadLine());
                return age;
            }
            int AskForNumberInRange(string text2, int min, int max)
            {
                while (true)
                {
                    Console.WriteLine("Enter a number " + text2);
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number >= min && number <= max)

                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Please,enter again,trying chose a valid number");
                    }

                }

            }

        }
    }
}

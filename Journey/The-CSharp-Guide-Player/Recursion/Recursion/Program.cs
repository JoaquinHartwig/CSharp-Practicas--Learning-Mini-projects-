namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Factorial(5)); 
            int Factorial(int number)
            {
                if (number == 1) return 1;
                return number * Factorial(number - 1);
            }
        }
    }
}
/*Factorial(5)
    ↓
5 × Factorial(4)
        ↓
    4 × Factorial(3)
            ↓
        3 × Factorial(2)
                ↓
            2 × Factorial(1)
                    ↓
                    1¨*/

/*Factorial(5)
esperando hacer:
5 *

↓

Factorial(4)
esperando hacer:
4 *

↓

Factorial(3)
esperando hacer:
3 *

↓

Factorial(2)
esperando hacer:
2 *

↓

Factorial(1)

↓

return 1*/
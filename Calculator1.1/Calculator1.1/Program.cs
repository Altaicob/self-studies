namespace Calculator1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opr;
            float first, second;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an operator(+,-,*,/): ");
                    opr = Console.ReadLine()[0];

                    //Contains method checks
                    if ("+-*/".Contains(opr))
                        break;

                }
                catch { }
                Console.WriteLine("The operator is invalid.");
            }

            while (true) 
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    first = float.Parse(Console.ReadLine());
                    break;
                }
                catch { }
                Console.WriteLine("Please enter a valid number.");
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    second = float.Parse(Console.ReadLine());
                    break;
                }
                catch { }
                    Console.WriteLine("Please enter a valid number.");
            }

            float result = 0;
            if (opr == '+')
                result = first + second;
            else if (opr == '-')
                result = first - second;
            else if (opr == '/')
                result = first / second;
            else if (opr == '*')
                result = first * second;

            Console.WriteLine($"Result of '{first} {opr} {second}' is: {result}");
        }
    }
}

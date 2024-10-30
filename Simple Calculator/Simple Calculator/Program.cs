using System.ComponentModel.Design;

namespace Simple_Calculator
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
                    Console.WriteLine("Enter an operator: ");
                    char opr = (Console.ReadLine()[0]);
                    Console.WriteLine("Enter a number: ");
                    float first = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a number: ");
                    float second = float.Parse(Console.ReadLine());
                    if (("+-*/".Contains(opr)) && (second != 0))
                        break;
                }
                catch
                {
                    Console.WriteLine("The operator is invalid.");
                }
            }
                float result = 0;
                switch (opr)
                {
                    case '+':
                        result = first + second;
                        Console.WriteLine($"The result of '{first} {opr} {second}' is: {result}");
                        break;
                    case '-':
                        result = first - second;
                        Console.WriteLine($"The result of '{first} {opr} {second}' is: {result}");
                        break;
                    case '*':
                        result = first * second;
                        Console.WriteLine($"The result of '{first} {opr} {second}' is: {result}");
                        break;
                    case '/':
                        if (second != 0)
                        {
                            result = first / second;
                            Console.WriteLine($"The result of '{first} {opr} {second}' is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed!");
                        }
                        break;

                    default:
                        Console.WriteLine($"Please enter a valid operator!");
                        break;
                }
                           
        }
    }
}

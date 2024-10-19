namespace BasicCalculation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an operation (+, -, /, *): ");  //Choosing an operation
            char opr = Console.ReadLine()[0];

            Console.Write("Enter the first number: ");
            float first = float.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            float second = float.Parse(Console.ReadLine());     // User numbers

            float result = 0;    
            if (opr == '+')               //Operator changes
                result = first + second;
            else if (opr == '-')
                result = first - second;
            else if (opr == '/')
                result = first / second;
            else if (opr == '*')
                result = first * second;

            Console.WriteLine($"The result of '{first} {opr} {second}' is: {result}");   // Result
        }
    }
}

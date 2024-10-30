using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Xml;

namespace T_F_Based_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User Specifies an operation
            //Read the numbers from 2 seperate folders and apply the operation
            //Results should be stored in the corresponding lines of a new file
            //
            
            char opr;

            while (true)
            {
                Console.Write("Enter an operator (+, -, /, *): ");
                
                if (char.TryParse(Console.ReadLine(), out opr) && "/-+*".Contains(opr))
                    break;

                Console.WriteLine("Invalid operator.");
            }

            //
            string Path1 = "C:\\Users\\USER\\Desktop\\1.txt";
            string[] items = File.ReadAllLines(Path1);

            string Path2 = "C:\\Users\\USER\\Desktop\\2.txt";
            string[] items2 = File.ReadAllLines(Path2);
            //

            float result = 0.0f, i1, i2;
            string output = "C:\\Users\\USER\\Desktop\\results.txt";
            using (StreamWriter writer = new StreamWriter(output))
            {
                for (int i = 0; i < items.Length; i++)
                {
                    i1 = float.Parse(items[i]);
                    i2 = float.Parse(items2[i]);

                    if (opr == '+')
                        result = i1 + i2;
                    else if (opr == '-')
                        result = i1 - i2;
                    else if (opr == '/')
                        result = i1 / i2;
                    else if (opr == '*')
                        result = i1 * i2;
                    writer.WriteLine(result);

                }
            }

            Console.WriteLine($"Results saved in {output}");

        }
    }
}

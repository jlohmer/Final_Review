using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            string anotherCalc;
            string operation;
            double result = 0;
            List<string> equations = new List<string>();

            do
            {
                Console.WriteLine("Please enter a number for left.");
                double Left = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter a number for right.");
                double Right = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Would you like to add, subtract, multiply, left to the power of right, or right to the power of left? (+,-,*,^L,^R)");
                operation = Console.ReadLine();

                Equation equation1 = new Equation();

                if (operation == "+")
                {
                    result = equation1.Add();
                }
                else if (operation == "-")
                {
                    result = equation1.Subtract();
                }
                else if (operation == "*")
                {
                    result = equation1.Multiply();
                }
                else if (operation == "^L")
                {
                    int power;
                    Console.WriteLine("What do you want the power to be?");
                    power = Convert.ToInt32(Console.ReadLine());
                    result = equation1.LeftToThePower(power);
                }
                else if (operation == "^R")
                {
                    int power;
                    Console.WriteLine("What do you want the power to be?");
                    power = Convert.ToInt32(Console.ReadLine());
                    result = equation1.RightToThePower(power);
                }
                Console.WriteLine($"{Left} {operation} {Right} = {result}");
                equations.Add($"{Left} {operation} {Right} = {result}");
                Console.WriteLine("Would you like to do another equation? (Y/N)");
                anotherCalc = Console.ReadLine().ToUpper();

            } while (anotherCalc == "Y");

            foreach (var calculation in equations)
            {
                Console.WriteLine(calculation);
            }
            Console.ReadKey();
        }
    }
}

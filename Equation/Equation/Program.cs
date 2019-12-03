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
            Equation equation1 = new Equation();
            double result = 0;

            Console.WriteLine("Please enter a number for left.");
            equation1.Left = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter a number for right.");
            equation1.Right = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Would you like to add, subtract, multiply, left to the power of right, or right to the power of left? (1,2,3,4,5)");
            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                result = equation1.Add();
            }
            else if (operation == 2)
            {
                result = equation1.Subtract();
            }
            else if (operation == 3)
            {
                result = equation1.Multiply();
            }
            else if (operation == 4)
            {
                int power;
                Console.WriteLine("What do you want the power to be?");
                power = Convert.ToInt32(Console.ReadLine());
                result = equation1.LeftToThePower(power);
            }
            else if (operation == 5)
            {
                int power;
                Console.WriteLine("What do you want the power to be?");
                power = Convert.ToInt32(Console.ReadLine());
                result = equation1.RightToThePower(power);
            }

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}

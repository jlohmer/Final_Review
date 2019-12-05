using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Equation
    {
        public double Left { get; set; }

        public double Right { get; set; }

        public Equation()
        {
            Left = 0;
            Right = 0;
        }

        public Equation(double left, double right)
        {
            Left = left;
            Right = right;
        }

        public double Add()
        {
            double answer = Left + Right;
            return answer;
        }

        public double Subtract()
        {
            double answer = Left - Right;
            return answer;
        }

        public double Multiply()
        {
            double answer = Left * Right;
            return answer;
        }

        public double LeftToThePower(int power)
        {
            double answer = Math.Pow(Left, power);
            return answer;
        }
        public double RightToThePower(int power)
        {
            double answer = Math.Pow(Right, power);
            return answer;
        }
    }
}

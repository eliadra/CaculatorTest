using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  public class Calculator
    {
        public static int Pluss(int first, int second)
        {
            return first + second;
        }
        public static double PlussDouble(double first, double second)
        {
            return first + second;
        }

        public static int Minus(int first, int second)
        {
            return first - second;
        }
        public static double MinusDouble(double first, double second)
        {
            return first - second;
        }

        public static int Multiplication(int first, int second)
        {
            return first * second;
        }
        public static double MultiplicationDouble(double first, double second)
        {
            return first * second;
        }

        public static int Division(int first, int second)
        {
            if (second != 0)
            { return first / second; }
            else { return 0; }
        }
        public static double DivisionDouble(double first, double second)
        {
            if (second != 0)
            { return first / second; }
            else { return 0; }
        }
    }
}

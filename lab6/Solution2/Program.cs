using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.1, 3.2
            int sign;
            bool isDecimal;
            double sqr;
            double abs;
            TaskA(4.2, out sign, out isDecimal, out sqr, out abs);
            Console.WriteLine(sign + " " + isDecimal + " " + sqr + " " + abs);

            // 3.3

            double a = 42;
            double b = -12.67;
            double c;
            double d;
            TaskA(a, out sign, out isDecimal, out c, out d);
            Console.WriteLine(sign + " " + isDecimal + " " + c + " " + d);
            TaskA(b, out sign, out isDecimal, out c, out d);
            Console.WriteLine(sign + " " + isDecimal + " " + c + " " + d);

        }
        public static void TaskA(double value, out int sign, out bool isDecimal, out double sqr, out double abs)
        {
            sign = Math.Sign(value);
            isDecimal = (value % 1 == 0) ? true : false;
            abs = Math.Abs(value);
            sqr = value * value;
        }
    }
}

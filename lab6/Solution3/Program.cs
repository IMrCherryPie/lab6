using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.1, 4.2

            int[] arrInt = { 1, 2, 3, 4 };
            Console.WriteLine(Avarage(arrInt));

            short a = 1;
            short b = 88;
            byte c = 3;
            Console.WriteLine(Avarage(a, b, c));

        }
        public static double Avarage(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }
    }
}

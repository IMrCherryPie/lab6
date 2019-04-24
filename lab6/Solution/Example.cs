using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Example
    {
        public int x;
        public int y;
        public Example(int x)
        {
            this.x = x;
        }
        public static void Init(ref Example Obj)
        {
            //Obj.x = 1;
            //Obj.y = 1;
            //Console.WriteLine("В методе Init. x = {0}\ty = {1}", Obj.x, Obj.y);
            Obj = new Example(4);
            Obj.y = 3;
            Console.WriteLine("В методе Init. x = {0}\ty = {1}", Obj.x, Obj.y);
        }
        public static void Sqr(ref double a, ref double b)
        {
            a = Math.Pow(a, 2);
            b = Math.Pow(b, 2);
            Console.WriteLine("В методе Sqr. a = {0}\tb = {1}", a, b);
        }
    }
}

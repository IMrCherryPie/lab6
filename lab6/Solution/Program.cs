using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 2;
            double y = 3;
            Console.WriteLine("В методе Main: x = {0}\ty = {1}", x, y);
            Example.Sqr(ref x , ref y);
            Console.WriteLine("В методе Main после вызова метода Sqr: x = {0}\ty = {1}", x, y + "\n");
            var Obj = new Example(2);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
            Example.Init(ref Obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);

            Console.WriteLine();

            double c = 0; // Ксли не проинициализировать переменную и отправить её в метод, то не стоит ожидать положительного результата
            Example.Sqr(ref x, ref c);

        }
    }
}

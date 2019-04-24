using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            Console.WriteLine("В методе Main: x = {0}\ty = {1}", x, y);
            Example.Sqr(x*2,y*2);
            Console.WriteLine("В методе Main после вызова метода: x = {0}\ty = {1}", x, y + "\n");
            var Obj = new Example(2);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
            Example.Init(Obj);
        }
    }
}

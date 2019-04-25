using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can send a comma-separated list of arguments of the 
            // specified type.
            MyClass.UseParams(1, 2, 3, 4);
            MyClass.UseParams2(1, 'a', "test");

            // A params parameter accepts zero or more arguments.
            // The following calling statement displays only a blank line.
            MyClass.UseParams2();

            // An array argument can be passed, as long as the array
            // type matches the parameter type of the method being called.
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            MyClass.UseParams(myIntArray);

            object[] myObjArray = { 2, 'b', "test", "again" };
            MyClass.UseParams2(myObjArray);

            // The following call causes a compiler error because the object
            // array cannot be converted into an integer array.
            //UseParams(myObjArray);

            // The following call does not cause an error, but the entire 
            // integer array becomes the first element of the params array.
            MyClass.UseParams2(myIntArray);
        }
        /*
Output:
    1 2 3 4
    1 a test
           
    5 6 7 8 9
    2 b test again
    System.Int32[]
*/
    }
}

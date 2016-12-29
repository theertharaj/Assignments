using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAnonymousMethods
{
    delegate void ArthemeticOperation(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous methods 
            ArthemeticOperation n1 = delegate (int a, int b)
              {
                  Console.WriteLine(a + b);
              };

            ArthemeticOperation n2 = delegate (int a, int b)
            {
                Console.WriteLine(a * b);
            };
            ArthemeticOperation n = n1 + n2;
            n(10, 20);
        }
    }
}

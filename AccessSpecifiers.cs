using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAcessSpecifiers
{
    class Demo
    {
        private int a; // accessed by only class members
        protected int b; //accessed by only class members and inherited class members
        public int c; // accessed by any members using object of the class
    }
    class Temp:Demo
    {

        String s;
        StringBuilder sb = new StringBuilder("Hello America!!");
        public void displayString()
        {
            sb.Append("Wonderfull"); // to add  text to string builder variable
            s = s + "Woderfull"; // to add  text to string variable
        }
        public void display()
        {
            //Console.WriteLine(a);//illegal not allowed as it is private;
            Console.WriteLine(b=20); // b can be accessed as it is inherited class
            Console.WriteLine(c=100); //c can be accessed as it is public
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            // d.a = 10; //illegal not allowed as it is private member
            //d.b = 20;  //illegal not allowed as it is protected member
            d.c = 30; // can be accessd as it is public member;
            Temp t = new Temp();
            t.display();
            t.displayString();
            t.displayString();
            Console.ReadLine();
        }
    }
}

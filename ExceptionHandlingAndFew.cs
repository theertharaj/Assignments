using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationExceptionhandling
{
    class Example
    {
       
        public int ID
        {
            get;
            set;
        }
        public static int number;
        public void display()
        {
            Console.WriteLine("Display Function and Number = " + number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var i = 10;
                Console.WriteLine("Type of var is casted to " + i.GetType());
                // i = "hello"; //cannot cast variable type multiple times
                //int k = null; // null values cannot be assigned for primitive/value type datatypes;
                int? j=null; // along with integers a null value can be assigned;
                Console.WriteLine("Try Block");
                Example e = new Example(); //when object is created static members are initialled with 0
                e.ID = 10; // normal variables, methods , properties are accesible via objects.
                //e.number=20;  // cannot use via object. because for all objects static member has only one reference.
                e.display(); //number will be 0
                Example.number = 20;  // have to access using Class Name
                e.display();

            }
            catch
            {
                //will be execute if try block is not completly executed
                Console.WriteLine("Catch Block");
            }

            finally
            {
                Console.WriteLine("Finally Block will always get executed");
            }
        }
    }
}

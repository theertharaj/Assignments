using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAbstractClass
{
   public interface IPrint
    {
        // All methods must be implemented at inherited class
        void displayAll();
        void displayInt(int i);
        void displayString(String s);
        void displayObject(Object o);
    }
 public   interface IFax
    {
        void dial( Int64 number);
        
    }
    abstract class Shape
    {
        // only abstract methods must provide implementation in the inherited class
        abstract public void area();
        abstract public void display();
        public virtual void print() // optional to override
        {
            Console.WriteLine("Base class Print ");
        }
       
    }
    class Square : Shape
    {
        public int Length
        {
            get;
            set;
        }
        public int Area
        {
            get;
            set;
        }
        
        public override void area()
        {
            Area = Length * Length;
        }
        public override void display()
        {
            Console.WriteLine("The area of the sqaure is " + Area);
        }
        public override void print()
        {
            Console.WriteLine("Child class print");
        }
        
    }
    class Rect : Shape
    {
        public int Length
        {
            get;
            set;
        }
        public int Area
        {
            get;
            set;
        }
         
            public int Breadth
            {
                get;
                set;
            }
         
        public override void area()
        {
            Area = Length * Breadth;
        }
        public override void display()
        {
            Console.WriteLine("The area of the Rectangle is " + Area);
        }
    }


    class Document:IPrint,IFax
    {
        void IPrint.displayAll()
        {

        }
       

        public void displayInt(int i)
        {
            Console.WriteLine("Displying Integer :" + i);
           // throw new NotImplementedException();
        }

        public void displayString(string s)
        {
            Console.WriteLine("Displying string :" + s);
            //throw new NotImplementedException();
        }

        public void displayObject(object o)
        {
            throw new NotImplementedException();
        }

        public void dial(long number)
        {
             Console.WriteLine("Dialing " + number);
            
           // throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Shape s = new Shape();//object cannot be instantiate for an abstract class
            Square g = new Square();
            g.Length = 10;
            Rect r = new Rect();
            r.Length = 4;
            r.Breadth = 5;
            Shape s =g;
            s.area();
            s.display();
            s = r;
            s.area();

            s.display();
            Document d = new Document();
            d.displayInt(10);
        
            d.displayString("Hello");
            d.dial(9980526571)
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplicationOopsExample
{
    class Student
    {
        private int id;
        private string name;
        public Student()
        {
            id = 0;
            name = "";
        }
        public Student(int i,string s)
        {
            id = i;
            name = s;
        }
        virtual public void display()
        {
            Console.WriteLine("ID = " + id + "\nName : " + name);
        }
    }
    class GradStudent:Student
    {
        private string major;
        private int gradyear;
        
        public GradStudent(int i, string s, string m, int g):base(i,s)
            //passing values to base class constructor
        {
            major = m;
            gradyear = g;
        }
        public GradStudent()
        {
            major = "";
            gradyear = 0;
        }
        //override display method 
        override public void display()
        {
            base.display();
            Console.WriteLine("Major= " + major + "\nGrad Year= " + gradyear);
        }
        
    }
    class UnderGradStudent : Student
    {
        private string minor;
        private float GPA;
        //constructor overloading and  passing parameter to base class constructor 
        public UnderGradStudent(int i,string s,string m,float g):base(i,s)
        {
            minor = m;
            GPA = g;
        }
        public UnderGradStudent()
        {
            minor = "";
            GPA = 0;
        }
        //overide function
        override public void display()
        {
            base.display();
            Console.WriteLine("Minor= " + minor + "\nGPA= " + GPA);
        }
    }
    class OverloadExample
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public float add(float a, float b)
        {
            return a + b;
        }

        public string add(string a, string b)
        {
            return a + b;
        }

        public double add(double a, double b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //array of student objects
            Student[] s = new Student[2];
            s[0] = new GradStudent(123,"Sachin","Computer Science",2016);
            s[1] = new UnderGradStudent(234, "Rahul", "Information",4);
            foreach(Student obj in s)
            {
                obj.display();
                Console.WriteLine("");
            }
//////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nArray List example");
            // Array list
            ArrayList i = new ArrayList();
            //can hold hetrogeneous data(any tyoe of data in an array)
            i.Add(10); //integer
            i.Add("Ramu");//string
            i.Add("IMCS");//string
            i.Add('M');//character
            i.Add("56.4");//float
            for (int j = 0; j<i.Count; j++)
            {
                Console.WriteLine(i[j]);
            }

/////////////////////////////////////////////////////////////////////////////////////////

            // Function over loading or static polymorphism
            Console.WriteLine("\noverloading example");
            OverloadExample obj1=new OverloadExample();
            int res=obj1.add(10, 20);
            Console.WriteLine(res);
            string res1 = obj1.add("Hello","  world ");
            Console.WriteLine(res1);
            double res2 = obj1.add(10.34, 20.66);
            Console.WriteLine(res2);
////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nBoxing and UNboxing example");
            int value= 1;
            object reference = value;       // boxing : Converting value type to reference type(object)
            Console.WriteLine(reference);
            int value1 = (int)reference;    // unboxing : converting reference type to value type
            Console.WriteLine(value1);
            Console.ReadLine();

        }
    }
}

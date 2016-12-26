using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationGenrics
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<int> s1 = new Student<int>(1001);
            Student<string> s2 = new Student<string>("RAMU");
            Student<bool> s3 = new Student<bool>(true);
            Console.ReadLine();
        }
    }
    //Genric datatype to replace with any type during runtime.
    class  Student<T>
    {
        public Student(T data)
        {
            Console.WriteLine(data);         
        }
            
    }
}

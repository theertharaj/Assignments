using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplicationHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
     
            h.Add("PAUL", 1);
            h.Add("Ramu", 2);
            h.Add("Ramesh", 3);
            h.Add("Rahul", 4);
            
            foreach(object i in h.Values)
            {
                int x=i.GetHashCode();
                Console.WriteLine(x);
            }
            foreach (object i in h.Keys)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class Program
    {
        public void Square()
        {
            int a = 10, b;
            b = a * a;
            Console.WriteLine("Square=" + b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Square();
            Console.ReadLine();
        }
    }
}

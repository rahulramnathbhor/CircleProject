using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c=new Circle();
            Console.WriteLine(c.display());
            Circle c2=new Circle(1.5);
            Console.WriteLine(c2.display());

        }
    }
}

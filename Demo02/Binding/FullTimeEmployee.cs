using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public double Salary { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("I'm Full Time Employee");
        }

        public override void Fun02()
        {
            Console.WriteLine($"Salary: {Salary}");
        }


    }
}

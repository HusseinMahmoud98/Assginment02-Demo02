using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Inheritance
{
    internal class Parent
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"From parent: X = {X}, Y = {Y}";
        }

        public void Fun01()
        {
            Console.WriteLine("I'm parent class [base]");
        }

        public void Fun02()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

    }
}

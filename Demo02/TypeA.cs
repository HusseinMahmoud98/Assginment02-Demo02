using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    internal class TypeA
    {
        public int A {  get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 from Type A");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A}");
        }
    }

    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 from Type B");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}");
        }
    }

    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 from Type C");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}, C: {C}");
        }
    }


    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 from Type D");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}, C: {C}, D: {D}");
        }
    }

    internal class TypeE : TypeD
    {
        public int E { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 from Type E");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A: {A}, B: {B}, C: {C}, D: {D}, E: {E}");
        }
    }


}

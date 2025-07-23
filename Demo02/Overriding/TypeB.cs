using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.Overriding
{
    internal class TypeB : TypeA
    {
        public int B {  get; set; }

        // override or hide
        // apply override
        // 1. Apply override using 'new' keyword
        // 2. apply override using 'override' keyword


        //Static Binding
        //Compiler will bind function call based on reference type not the object type
        //At compilation time
        public new void Fun01() //using new keyword
        {
            Console.WriteLine("Fun01 from typeB");
        }


        //Dynamic Binding
        //CLR will bind the function call based on the object not the reference type
        //At runtime
        public override void Fun02() //using override keyword
        {
            Console.WriteLine($"A = {A}, B = {B}");
        }
    }
}

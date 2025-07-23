using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class TypeD : TypeA
    {
        public TypeD() 
        {
            //A =1; //Invalid - Not Inherited [Private]
            //B = 2; //Invalid -Not Inherited [Internal]
            C = 3; //Valid : [Public]

            //X = 10; //Invalid - Not Inherited [Private Protected]
            Y = 20; // Valid - Inherited [Protected] => [Private]
            Z = 30; // Valid - Inherited [Internal Protected] => [Private]
        }
    }
}

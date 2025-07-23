using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeC
    {
        public void Fun01()
        {
            TypeB typeBObj = new TypeB();

            typeBObj.B = 2; //Valid - Internal
            typeBObj.C = 3; //Valid - Public
            //typeBObj.X = 10; // Invalid: Private
            //typeBObj.Y = 20; //Invalid: Private
            typeBObj.Z = 30; //Valid: Internal 

        }
    }
}

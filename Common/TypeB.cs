using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB : TypeA
    {
        public TypeB() 
        {
            //A = 1; //Invalid: (Not inherited because its private)
            B = 2;  //Valid: (Can be inherited because its Internal)
            C = 3; //Valid: Inherited and public
            X = 4; //Valid: Because its private protected and its become private to this class => Private
            Y = 5; //Valid: Inherited - Protected => Private
            Z = 6; //Valid: Inherited : Internal protected
        
        }
      
        public void Print()
        { 
            TypeA typeAObj = new TypeA();
            //typeAObj.A = 1; Invalid: A is private
            typeAObj.B = 2; //Valid: internal
            typeAObj.C = 3; //Valid: public
            //typeAObj.X = 10; //Invalid: private protected
            //typeAObj.Y = 20; //Invalid: private
            typeAObj.Z = 30; //Valid : internal protected
        
        }
    }
}

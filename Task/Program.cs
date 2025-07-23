using Common;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Private: Not inherited and can be accessed only within the same class
            //Internal: Inherited and accessible within the assembly only
            //Public: Inherited and accessible inside and outside assembly
            //Private Protected: Inherited as private inside assemly only
            //Protected: Inherited as private inside - outside assembly
            //Internal protected: Inherited as internal inside assembly AND inherited as private outside assembly

            #region Parent TypeA Test
            TypeA typeAObj = new TypeA();

            //typeAObj.A = 1; Invalid: A is private
            //typeAObj.B = 2; //Valid: internal
            typeAObj.C = 3; //Valid: public
            //typeAObj.X = 10; //Invalid: private protected
            //typeAObj.Y = 20; //Invalid: private
            //typeAObj.Z = 30; //Valid : internal protected 
            #endregion

            #region Child TypeB Test
            TypeB typeBObj = new TypeB();

            //typeAObj.B = 2; //Invalid: internal
            typeAObj.C = 3; //Valid: public
                            //typeAObj.X = 10; //Invalid: private
                            //typeAObj.Y = 20; //Invalid: private
                            //typeAObj.Z = 30; //Valid : internal 


            #endregion

            #region Child TypeD Test
            TypeD typeDObj = new TypeD();

            typeDObj.C = 3; //valid [Public]
            //typeDObj.Y = 20; //Invalid [Privte]
            //typeDObj.Z = 30; //Invalid [Private]
            #endregion
        }
    }
}

using Demo02.Binding;
using Demo02.Inheritance;
using Demo02.Overriding;

namespace Demo02
{
    internal class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sum(int x, int y, int z)
        {
            return x + y +z;
        }

        static double Sum(double x, double y)
        {
            return x + y;
        }

        static double Sum(double x, double y, double z)
        {
            return x + y + z;
        }

        static void EmployeeProcess(Employee employee)
        {

            if (employee is not null)
            {
                employee.Fun01();
                employee.Fun02();
            }
            
        }

        static void Main(string[] args)
        {

            #region Inheritance
            ////Parent
            //Parent parent = new Parent(1, 2);
            //Console.WriteLine(parent.ToString());
            //parent.Fun01();
            //parent.Fun02();


            ////Child
            //Child child = new Child(10, 20, 30);
            //Console.WriteLine(child.ToString());
            //child.Fun01();
            //child.Fun02();
            #endregion

            #region Polymorphism Overloading
            //// There are more than one function that  have the same name (in the same scope)
            //// but different signature (count - type - order)
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(1, 2, 3));
            //Console.WriteLine(Sum(2.1, 3.3));
            //Console.WriteLine(Sum(1.1, 2.2, 3.3));
            #endregion

            #region Polymorphism Overriding
            ////There are more than one function [in different class] these have
            ////the same name and same signature but with different behavaiour

            //TypeB typeB = new TypeB(){ A = 12, B = 13 } ;
            ////typeB.A = 1;
            ////typeB.B = 2;

            //typeB.Fun01();
            //typeB.Fun02();

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            #endregion

            #region What Is Binding?
            ////What is binding?
            //// Reference From Parent ---> ObjectChild
            //TypeA Ref;

            ////Ref = new TypeA();
            ////Ref = new TypeB();

            ////Child is a Parent
            ////TypeB is a TypeA

            //Ref = new TypeB();

            //Ref.A = 5;
            ////Ref.B = 6; Invalid

            //Ref.Fun01(); //Fun01 from type A (Static Binding Method)
            //Ref.Fun02(); //A = 5, B = 0 (Dynamic Binding Method)





            #endregion

            #region Not Binding!
            // Binding
            // RefParent ---> ObjChild

            //TypeB Ref = new TypeB();
            //Ref = new TypeA(); // Invalid: NOT Binding

            //Child is a Parent

            // Animal --> Dog :  Dog is an Animal
            // Dog --> Ainmal : Aimal is a Dog (Invalid)

            #endregion

            #region When do you need Binding?
            //// Full time employee -------------------------------
            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Hussein",
            //    Email = "hussein.mahmoud.fouad98@gmail.com",
            //    Address = "Cairo",
            //    Salary = 12000
            //};

            //EmployeeProcess(fullTime);

            //// Part time employee -------------------------------
            //PartTimeEmployee partTime = new PartTimeEmployee()
            //{
            //    Id = 2,
            //    Name = "Mahmoud",
            //    Email = "hussein.mahmoud.fouad98@gmail.com",
            //    Address = "Alex",
            //    HourRate = 100,
            //    NumberOfHours = 100
            //};

            //EmployeeProcess(partTime);
            #endregion

            #region Binding Example
            //TypeA typeA;

            //typeA = new TypeA(); 
            //typeA = new TypeB(); // TypeA is a parent of TypeB
            //typeA = new TypeC(); // TypeA is an indirect parent of TypeC
            //typeA = new TypeD(); // TypeA is an indirect parent of TypeD
            //typeA = new TypeE(); // TypeA is an indirect parent of TypeE

            //typeA.A = 1;
            ////typeA.B = 2; //Invalid
            ////typeA.C = 2; //Invalid
            ////typeA.D = 2; //Invalid

            //typeA.Fun01(); //Fun01 from Type A
            //typeA.Fun02();



            #endregion

        }
    }
}

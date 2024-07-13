using DemoOOP02.Encapsoulation;
using DemoOOP02.Inheritance;

namespace DemoOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsoultion
            Employee employee=new Employee(10,"Mohamed",6000);// new select constructor 
            Console.WriteLine(employee);
            //Id =10, Name =Mohamed ,salary = 6000
            employee.Id = 20; // set id Directly through Attribute
            Console.WriteLine(employee.Id);// get id Directly through Attribute
            //employee.Name = "Mido"; // Invaild
            employee.SetName("Ahmed Mona"); // Set Name Using Setter Method
            Console.WriteLine(employee.GEtName()); // Vaild Get Name using Getter Method
            //employee.Salary = 1000; //Invaild
            employee.salary = 2000; // vaild set salary using property  as a setter
            Console.WriteLine(employee.salary); // Get salary using property as a getter
            //Recommended =>it is easy  to use like attribute
            Console.WriteLine(employee.Deduction);
            #endregion
            #region Indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Moha", 123);
            //Note.AddPerson(1, "Mido", 456);
            //Note.AddPerson(2, "Ashraf", 789);
            ////Console.WriteLine(Note.GetPersonNumber("Mido") == -1?"Person Not Found":Note.GetPersonNumber("Mido"));
            ////Note.setpersonNumber("Mido", 999);
            ////Console.WriteLine(Note.GetPersonNumber("Mido") == -1 ? "Person Not Found" : Note.GetPersonNumber("Mido"));
            //Console.WriteLine(Note["Mido"]); // using Indexer As A Getter
            //Note["Mido"] = 999;// Using Indexer As a Setter
            //Console.WriteLine(Note["Mido"]);
            //for (int i = 0; i < Note.Size; i++)
            //{
            //    Console.WriteLine(Note[i]);
            //}
            #endregion
            #region Class
            /// Car C1; //Declare to ref from type "Car" .. Can refer to an object from type car 
            //clr will allocate 4 bytes for Reference "C1" at stack 0 bytes at Heap
            /// C1 = new Car();
            // new =>
            //1.Allocate required bytes at heap
            //2.initailzed the allocate bytes with Default value of datatype
            //3.call user defined Constructor [ifExisits]
            //4.Assign the Reference "C1"to Allocated object at heap
            // Console.WriteLine(C1);

            //Car C1 = new Car(10, "Bmw", 320);
            //Console.WriteLine(C1);
            //Console.WriteLine("---------------------");
            //Car C2 = new Car(20, "Nissan");
            //Console.WriteLine(C2);
            Console.WriteLine("=====================");
            Car C3 = new Car(50);
            Console.WriteLine(C3);
            #endregion
            #region Inhertance
            Parent p1 = new Parent(1, 2);
            Console.WriteLine(p1); //(1,2)
            Console.WriteLine(p1.Product());//2
             Child C = new Child( 3,4,5);
            Console.WriteLine(C); // child to string
            Console.WriteLine(C.Product()); // child
            Type_A objA = new Type_A();
            //objA.X = 10;//Invaild[private]
            //objA.y = 20;// Invaild [private]
            //objA.M = 40; //invaild [private]
            //objA.Z = 60; // Vaild [internal available Access same project]

            TypeB objB = new TypeB();


            #endregion

        }
    }
}

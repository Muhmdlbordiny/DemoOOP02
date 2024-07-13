using AssignmentOOP_02.Items;

namespace AssignmentOOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            // is a Demo 
            #endregion
            #region part02
            #region Q1
            /*Define a struct "Person" with properties "Name" and "Age". 
             * Create an array of three "Person" objects and populate it with data. Then,
             * write a C# program to display the details of all the persons in the array.
             */
           Person p1 = new Person(25,"Mohamed");
            Person p2 = new Person(30, "ahmed");
            Person p3 = new Person(40, "Ali");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


            #endregion
            #region Q2
            /*2 Create a struct called "Person" with properties "Name" and "Age". Write a 
             * C# program that takes details of 3 persons as input from 
             * the user and displays the name and age of the oldest person.*/
            try
            {
                Person p4 = new Person(int.Parse(Console.ReadLine()), Console.ReadLine());
                Console.WriteLine(p4);

                Person p5 = new Person(int.Parse(Console.ReadLine()), Console.ReadLine());
                Console.WriteLine(p5);

                Person p6 = new Person(int.Parse(Console.ReadLine()), Console.ReadLine());

                Console.WriteLine(p6);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            #endregion

            #endregion
            #region part03
            #region Q1
            /*1.Design and implement a Class for the employees in a company:
             ⮚	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            */

            #endregion
            #region Q2
            /*2.Develop a Class to represent the Hiring Date Data:
                ⮚	consisting of fields to hold the day, month and Years.
            */
            Employee Emp01 = new Employee();
            Emp01.hiredate = DateTime.Now;
            Console.WriteLine(Emp01.hiredate);
            #endregion
            #region Q3
            /*3.	We need to restrict the Gender field to be only M or F [Male or Female] */
            Console.WriteLine("Enter your Type Person :");
            Emp01.Gender = Console.ReadLine();
            if(Emp01.Gender =="Male"||Emp01.Gender =="M"||Emp01.Gender =="F"||Emp01.Gender=="Female")
            {
                Console.WriteLine(Emp01.Gender);
            }
            #endregion
            #region Q4
            /*4.	Assign the following security privileges to the employee
             * (guest, Developer, secretary and DBA) in a form of Enum*/
            #endregion
            #region Q5
            /*5.We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()),
             * display employee salary in a currency format. [ use String.Format Function]
             */
            Emp01.Salary = 6000;
            Console.WriteLine(Emp01);
            #endregion
            #region Q6
            /*
             * 6.Create an array of Employees with size three a DBA,
             * Guest and the third one is security officer who have full permissions.
             * (Employee [] EmpArr;)
             */
            Emp01.caller = Caller.guest;
            if((Emp01.caller & Caller.guest) == Caller.guest)
            {
                Console.WriteLine("guest is Exists");
                Console.WriteLine(Emp01.caller);
            }
            
            if ((Emp01.caller &Caller.Developer) == Caller.Developer)
            {
                Console.WriteLine("Developer is Exisits ");
                Console.WriteLine(Emp01.caller);

            }
            else
            {
                Emp01.caller = Emp01.caller ^ Caller.Developer;

            }
            if ((Emp01.caller & Caller.seceratery) == Caller.seceratery)
            {
                Console.WriteLine("seceratery is a Exisits :");
                Console.WriteLine(Emp01.caller);

            }
            else
            {
                Emp01.caller = Emp01.caller ^ Caller.seceratery;

            }
            if ((Emp01.caller & Caller.DBA) == Caller.DBA)
            {
                Console.WriteLine(Emp01.caller);
            }
            else
            {
                Emp01.caller = Emp01.caller ^ Caller.DBA;

            }
            Console.WriteLine("----------------");
            Console.WriteLine(Emp01.caller);
            #endregion
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Encapsoulation
{
    internal struct Employee
    {
        //Encapsulation
        //Separate Data Definition [Attributes] From Its Use [Getter Setter , Property]
        //a. private attribute
        //b.[getter setter]-[property]


        #region Attributes
        public int Id;
       private string? EmpName;
       private decimal Salary;
        //private int age;



        public Employee(int id, string? name, decimal salary /*int _Age*/)
        {
            Id = id;
            EmpName = name;
            Salary = salary;
            //this.age = _Age;
        }
        #region  Appling Encapsulation using Getter & setter Function
        //Getter 
        public string? GEtName()
        {
            return EmpName;

        }

        //setter 
        public void SetName(string? name)
        {
            EmpName = name?.Length>5?name.Substring(0,5) :name;
        }
        public override string ToString()
        {
            return $"ID ={Id}\n Name :{EmpName} \n salary: {Salary:c}";
        }
        #endregion
        #region 2.Appling Encapsulation Property
        //property [Fullproperty -Automatic property -indexer]
        public decimal salary
        {
            get { return Salary; }
            set 
            {
                Salary = value<3000?3000:value;// Assigned Value
            }
        }
        //[Full property]
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //Automatic property
        public int Age { get; set; }
        // Compiler will generate hidden private attribute [Backing Field]
        //private decimal deduction;[Derived Attribute]
        public decimal Deduction // Read only property
        {
            get { return salary * 0.2M; }
        }
        //Full property =>propfull
        private string test;

        public string Test
        {
            get { return test; }
            set { test = value; }
        }
        public int MyProperty { get; set; } // Automatic=> prop

        #endregion

        #endregion

    }
}

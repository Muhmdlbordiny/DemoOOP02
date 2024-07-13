using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02
{
    internal class Car
    {
        #region property
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        #region Constructor
        //Empty parameterless constructor
        //public Car()
        //{
        //    // Do nothing
        //}
        public Car(int id,string model,double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("Cto01");

        }
        //Constructor Chaining
        public Car(int id , string model):this(id,model ,280)
        {
            //Id=id;
            //Model = model;
            //Speed = 280;
            Console.WriteLine("Cto02");

        }
        public Car(int id) :this(id,"Audi",350)
        {
            //Id = id;
            //Model = "Audi";
            //Speed = 350;
            Console.WriteLine("Cto03");
        }
        #endregion

        public override string ToString()
        {
            return $"CarID :{Id}\nModel :{Model}\n:Speed :{Speed}";
        }

    }
}

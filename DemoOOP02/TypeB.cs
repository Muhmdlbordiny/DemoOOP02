using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02
{
    public class TypeB :Type_A
    {
        public TypeB()
        {
            X = 10;// X is protected private => Inheritance As private
            Y = 20; // Y is protected => inheritance as private
            Z= 30;// vaild is internal protected => inherted as internal
            M = 40;// Invaild [Not inhertance]
        }
        //public void print()
        //{
        //    Type_A obj = new Type_A();
        //    //obj.X = 10; // Invaild [private]
        //    //obj.Y = 30; // invaild [private]
        //    //obj.Z = 20; // vaild [internal]
        //    //obj.M = 60; // invaild [private]
        //}
    }
}

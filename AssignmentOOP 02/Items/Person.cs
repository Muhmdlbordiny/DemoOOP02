using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP_02.Items
{
    internal struct Person
    {
        //public int[] Age;
        //public string?[] Names;
        //public int size;

        //public int Size
        //{
        //    get { return size; }
        //}
        //public int this[string name]
        //{
        //    get
        //    {
        //        if (Names is not null && Age is not null)
        //            for (int i = 0; i < Names.Length; i++)
        //                if (Names[i] ==name)
        //                {
        //                    return Age[i];
        //                }
        //        return -1;
        //    }
        //    set
        //    {
        //        if (Names is not null && Age is not null)
        //        {
        //            for (int i = 0; i < Names.Length; i++)

        //                if (Names[i] == name)
        //                {
        //                    Age[i] = value;
        //                    break;
        //                }

        //        }
        //    }
        //}
        private int Age;
        private string? Name;
        public Person(int age ,string name)
        {
            Name = name;
            Age = age;
        }
        //Method
        public string? GetName()
        {
            return Name;
        }
        public void SetName(string? name)
        {
            Name = name?.Length>5?name.Substring(0,5):name; 
        }
        public override string ToString()
        {
            return $" Age is :{Age} Name is {Name}";
        }
    }
}

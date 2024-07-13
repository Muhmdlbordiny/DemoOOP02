using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP02.Inheritance
{
    internal class Parent
    {
        #region Constructor
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        } 
        #endregion

        #region property
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        #region Method
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        //object member mehod
        public virtual int Product()
        {
            return X * Y;
        } 
        #endregion

    }
}

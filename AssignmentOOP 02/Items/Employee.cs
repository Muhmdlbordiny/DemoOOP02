﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP_02.Items
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary {  get; set; }
        public DateTime hiredate { get; set; }= DateTime.Now;
        public string Gender {  get; set; }
        public Caller caller;
        public override string ToString()
        {
            return $"salary = {Salary:c}";
        }
    }
    
}
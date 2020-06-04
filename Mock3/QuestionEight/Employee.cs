using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionEight
{
   public abstract class Employee
    {

        protected string Name { get; set; } 
        protected double Salary { get; set; } 
        
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name is {Name}; Salary is {Salary}.";
        }
    }
}

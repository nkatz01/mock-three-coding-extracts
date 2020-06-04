using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionEight
{
    public class Programmer : Employee
    {
        protected double AverageOverTime {get; set;}
        public Programmer(string name, double salary, double averageOvertime) : base(name, salary) { AverageOverTime = averageOvertime; }

        public override string ToString()
        {
            return $"Name is {Name}; Salary is {Salary}; Average Over Time is {AverageOverTime}.";
        }
    }
}

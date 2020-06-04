using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionEight
{
    public class Intern : Employee
    {
        protected int InternshipMonths { get; set; }
        public Intern(string name, double salary, int internshipMonths) : base(name, salary) { InternshipMonths = internshipMonths; }

        public override string ToString()
        {
            return $"Name is {Name}; Salary is {Salary}; Internship duration is {InternshipMonths}.";
        }
    }
}

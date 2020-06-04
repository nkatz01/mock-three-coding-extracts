using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionEight
{
    public class Manager : Employee
    {
        protected string ManagersAsistant { get; set; }
        public Manager(string name, double salary, string managersAsistant) : base(name, salary) { ManagersAsistant = managersAsistant; }

        public override string ToString()
        {
            return $"Name is {Name}; Salary is {Salary}; Assitant Manager is {ManagersAsistant}.";
        }
    }
}

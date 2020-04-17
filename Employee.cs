using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExam1
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }


    }
}

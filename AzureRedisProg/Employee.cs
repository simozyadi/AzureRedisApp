using System;
using System.Collections.Generic;
using System.Text;

namespace AzureRedisProg
{
    class Employee
    {
        IList<string> orders;
        public string Name
        {
            set; get;
        }

        public string Id
        {
            set; get;
        }

        public int Age { get; set; }

        public Employee()
        {
            orders = new List<string>();
        }

        public Employee(string employeeId, string name, int age)
            : this()
        {
            Id = employeeId;
            Name = name;
            Age = age;
        }
    }
}

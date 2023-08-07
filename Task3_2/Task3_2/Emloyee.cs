using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    internal class Emloyee
    {
        private string name;
        private int age;
        private double salary;

        public Emloyee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public double gatSalary()
        {
            return salary;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }

    }
}

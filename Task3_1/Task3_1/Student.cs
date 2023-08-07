using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    internal class Student
    {

        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public double getGrade()
        {
            return grade;
        }
        public void setGrade(double grade)
        {
            this.grade = grade;
        }
    }
}

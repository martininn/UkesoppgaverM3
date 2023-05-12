using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkesOppgaveUke2
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student()
        {
            
        }
        public Student(string name)
        {
            Name = name;
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }
    }
}

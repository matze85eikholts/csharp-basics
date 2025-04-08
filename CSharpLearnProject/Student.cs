using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject
{
    public class Student : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; } // Дополнительное свойство для студента

        public Student(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public void Introduce()
        {
            Console.WriteLine($"Привет! Я студент {FirstName} {LastName}. Учусь в {Grade} классе.");
        }


    }
}

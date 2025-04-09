using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject
{
    public class Teacher : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Introduce() {
            Console.WriteLine("Hello");
        }
    }
}

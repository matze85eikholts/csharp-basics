using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject.dependency_injection
{
    public class Dog
    {
        public string Name { get; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} говорит: Гав-гав!");
        }
    }
}

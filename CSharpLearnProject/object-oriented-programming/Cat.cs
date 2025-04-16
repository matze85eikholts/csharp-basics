using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject.object_oriented_programming
{
    public class Cat : Animal
    {
        public override string Name { get; }
        public Cat() { 
            Name = string.Empty;
        }
        public Cat(string name)
        {
            Name = name;
        }

        public void Meow() {
            Console.WriteLine($"a cat with Name {Name} is meowing to you Hello!!!");
        }
        public override void MakeSound()
        {
            Meow();//throw new NotImplementedException();
        }
    }
}

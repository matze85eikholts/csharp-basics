using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject.dependency_injection
{
    public class Owner
    {
        private readonly Dog _dog;

        // Внедрение зависимости через конструктор
        public Owner(Dog dog)
        {
            _dog = dog ?? throw new ArgumentNullException(nameof(dog));
        }
        public void CallDog()
        {
            Console.WriteLine("Хозяин зовёт собаку...");
            _dog.Bark();
        }
    }
}

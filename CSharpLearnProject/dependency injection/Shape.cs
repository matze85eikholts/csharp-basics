using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject.dependency_injection
{


    // Абстрактный класс
    public abstract class Shape
    {
        // Абстрактное свойство (должно быть реализовано в производных классах)
        public abstract string Name { get; }

        // Абстрактный метод (должен быть реализован в производных классах)
        public abstract double CalculateArea();

        // Реализованный метод (может использоваться в производных классах)
        public void DisplayInfo()
        {
            Console.WriteLine($"Фигура: {Name}, Площадь: {CalculateArea()}");
        }
    }
   
    
}

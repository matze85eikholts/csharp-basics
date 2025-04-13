using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnProject.dependency_injection
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        // Реализация абстрактного свойства
        public override string Name => "Круг";

        // Конструктор
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Реализация абстрактного метода
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

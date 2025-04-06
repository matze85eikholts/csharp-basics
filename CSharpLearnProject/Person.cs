

namespace CSharpLearnProject
{
    public class Person
    {
        // Свойства класса
        public string Name { get; set; }
        public int Age { get; set; }
       
        // Конструктор по умолчанию
        public Person()
        {
            Name = "Valera";
            Age = 0;
        }

        // Параметризованный конструктор
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Метод для вывода информации о человеке
        public int Sum(int a, int b)
            { return a + b; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}

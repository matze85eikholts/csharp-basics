// See https://aka.ms/new-console-template for more information
//
//Console.WriteLine("Hello, World!");

using System;
using CSharpLearnProject;
using CSharpLearnProject.dependency_injection;

public class MainClass {

    static int Sum(int a, int b) {
        int sum = 0;
        return sum = a + b;
    }
    public static void Main()
    {
        int a = 2, b = 3;
        int sum = Sum(a, b);    
        Console.WriteLine("Hello, my dear friend!!!");
        Console.WriteLine(sum);
        // Создание объекта с использованием конструктора по умолчанию

        Person person1 = new Person();
        Console.WriteLine("Using default constructor:");
        person1.DisplayInfo();

        // Создание объекта с использованием параметризованного конструктора
        Person person2 = new Person("Alice", 30);
        Console.WriteLine("\nUsing parameterized constructor:");
        person2.DisplayInfo();
        IPerson teacher = new Teacher("Ivan", "Ivanov");
        teacher.Introduce();

        // Создаём экземпляр собаки
        var dog = new Dog("Барон");

        // Внедряем собаку в хозяина через конструктор
        var owner = new Owner(dog);

        // Хозяин зовёт собаку
        owner.CallDog();
    }
}
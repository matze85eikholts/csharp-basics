// See https://aka.ms/new-console-template for more information
//
//Console.WriteLine("Hello, World!");

using System;
using CSharpLearnProject;

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
    }
}
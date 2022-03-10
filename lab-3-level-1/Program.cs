using System;
using System.Collections.Generic;
using System.Linq;

// Задание 5
namespace level_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            Console.WriteLine("Введите значения первого массива. Форма ввода: x y z n");
            var x1 = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            Console.WriteLine("Введите значения второго массива. Форма ввода: x y z n");
            var x2 = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            int sum = 0;
            for (int i = 0; i < x1.Length; i++)
            {
                sum += x1[i] * x2[i];
            }
            Console.WriteLine(sum);
        }
    }
}
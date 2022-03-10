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
            Console.WriteLine("Введите массив");
            var array = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));
            Array.Sort(array);
            Console.WriteLine(array);
        }
    }
}
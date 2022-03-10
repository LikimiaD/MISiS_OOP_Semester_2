/*
 * Вариант: 8
 * Задание: Вычислить s = 1! + 2! + ... + 6!
 * Уровень: 1
 */
namespace Level_1
{
    public class Program
    {
        public static int Factorial(int x)
        {
            int sum = 0;
            int n;
            while (x > 0)
            {
                n = 1;
                for (int i = x; i > 0; i--)
                {
                    n *= i;
                }
                sum += n;
                x--;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            Console.WriteLine($"Факторил 6! = {Factorial(6)}");
            Console.ReadKey();
        }
    }
}
/*
 * Вариант: 8
 * Уровень: 3
 */
namespace Level_3
{
    public class Program
    {
        public static int Factorial(int n)
        {
            if (n < 2) return 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            double s = 0.0, n = 0.0;

            double a = 0.1, b = 1.0, h = 0.1;
            for (int i = 0; a <= b; a += h, i++)
            {
                n = Math.Pow(2 * a, i) / Factorial(i);

                if (n < 0.0001) break;
                s += n;

                Console.WriteLine("x={0}\ty={1}\ts={2}", Math.Round(a * 100) / 100, Math.Pow(Math.E, 2 * a), s);
            }
            Console.WriteLine("S = {0}", s);
            Console.ReadLine();
        }
    }
}
/*
 * Вариант: 10
 * Задание: В задаче 15 уровня I вычислить член последовательности,
 *          который отличается от предыдущего члена не более чем на 0,001.
 * Уровень: 2
 */
namespace Level_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            int a, b, c, d;
            a = 3;
            b = 2;
            c = 1;
            while (Math.Abs((float)a / b - (float)b / c) > 0.001)
            {
                d = a;
                a += b;
                c = b;
                b = d;
            }
            Console.WriteLine("Ответ: {0}/{1}", a, b);
            Console.ReadKey();
        }
    }
}
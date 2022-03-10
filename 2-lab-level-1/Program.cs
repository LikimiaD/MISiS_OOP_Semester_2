/*
 * Вариант: 10
 * Уровень: 1
 */
namespace Level_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            int y = 0;
            int x = Int32.Parse(Console.ReadLine());

            if (x <= -1)
                y = 1;
            if ((1 < x) & (x <= 1))
                y = -x;
            if (x > 1)
                y = -1;
            Console.WriteLine("x={0}\ty={1}", x, y);
        }
    }
}
/*
 * Вариант: 2
 * Уровень: 1
 */
namespace Level_1
{
    public class Program
    {
        public static Random rnd = new Random();
        public static void Main(string[] args)
        {
            int fa,fb,fc,sa,sb,sc;
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            fa = rnd.Next(30, 100); fb = rnd.Next(30, 100); fc = rnd.Next(30, 100);
            sa = rnd.Next(30, 100); sb = rnd.Next(30, 100); sc = rnd.Next(30, 100);
            double x1 = Math.Sqrt(P(fa, fb, fc) * (P(fa, fb, fc) - fa) * (P(fa, fb, fc) - fb) * (P(fa, fb, fc) - fc));
            double x2 = Math.Sqrt(P(sa, sb, sc) * (P(sa, sb, sc) - sa) * (P(sa, sb, sc) - sb) * (P(sa, sb, sc) - sc));
            Console.WriteLine("{0} больше\nПервый треугольник - {1}\nВторой треугольник - {2}", x1 > x2 ? "Первый" : "Второй", x1, x2);
        }
        public static int P(int a,int b,int c)
        {
            var answer = (a + b + c) / 2;
            return answer;
        }
    }
}
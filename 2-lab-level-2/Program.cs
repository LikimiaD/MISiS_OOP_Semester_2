/*
 * Вариант: 1
 * Уровень: 2 + Возможно 3 
 */
namespace Level_2
{
    public class Program
    {
        public static Random rnd = new Random();
        public static double avarage_height_boy;
        public static double avarage_height_girl;
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            Console.WriteLine("Введите минимальный рост ученика");
            int min_height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальный рост ученика");
            int max_height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во девочек в классе");
            int[] value_girls = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Кол-во мальчиков в классе");
            int[] value_boys = new int[Convert.ToInt32(Console.ReadLine())];
            for (int id = 0; id < value_girls.Length; id++) value_girls[id] = rnd.Next(min_height, max_height);
            for (int id = 0; id < value_boys.Length; id++) value_boys[id] = rnd.Next(min_height, max_height);
            Console.WriteLine("Кол-во мальчиков - {0}\tКол-во девочек - {1}", value_boys.Length, value_girls.Length);
            foreach (var item in value_girls) avarage_height_girl += item;
            foreach (var item in value_boys) avarage_height_boy += item;
            Console.WriteLine("Средний рост мальчиков в классе = {0}\tСредний рост девочек в классе = {1}", Math.Round(avarage_height_boy / value_boys.Length, 2), Math.Round(avarage_height_girl / value_girls.Length, 2));
        }
    }
}
/*
 * Вариант: 14
 * Уровень: 1
 */
namespace Level_1
{
    public class Program
    {
        public static int[,] matrix = new int[4, 3];
        public static void create_matrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            int[] arr = new int[matrix.GetLength(0)];
            create_matrix();
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j] < 0 ? matrix[i, j] : 0;
                }
                Console.Write(sum + "\t");
                arr[i] = sum;
                Console.WriteLine();
            }
        }
    }
}
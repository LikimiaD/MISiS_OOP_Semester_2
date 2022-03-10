/*
 * Вариант: 8
 * Уровень: 2
 */
namespace Level_2
{
    public class Program
    {
        public static int[,] matrix = new int[6, 6];
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
            create_matrix();
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i = i + 2)
            {
                int max1 = 0,max1x = 0, max1y = 0; int max2 = 0, max2x = 0, max2y = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max1)
                    {
                        max1 = matrix[i, j];
                        max1x = i;
                        max1y = j;
                    }
                    if (matrix[i+1, j] > max2)
                    {
                        max2 = matrix[i+1, j];
                        max2x = i+1;
                        max2y = j;
                    }
                }
                Console.WriteLine("Максимальные числа: {0} {1}",max1,max2);
                matrix[max1x,max1y] = max2;
                matrix[max2x,max2y] = max1;
            }
            Console.WriteLine("Актуальная матрица");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
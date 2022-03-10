/*
 * Вариант: 2
 * Уровень: 3
 */
namespace Level_3
{
    public class Program
    {
        internal static class GeneratorMartix
        {
            private static readonly Random generator = new Random();
            public const int RowSize = 6;
            public const int ColumnSize = 5;
            public static int[,] GetMatrix()
            {
                var matrix = new int[RowSize, ColumnSize];
                for (var i = 0; i < RowSize; i++)
                    for (var j = 0; j < ColumnSize; j++)
                        matrix[i, j] = generator.Next(-10, 10);
                return matrix;
            }
            public static void Print(int[,] matrix)
            {
                for (int i = 0; i < RowSize; i++)
                {
                    for (int j = 0; j < ColumnSize; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static class MatrixHelper
        {
            public static void sort_arr(int[,] matrix)
            {
                for (int i = 0; i < GeneratorMartix.RowSize; i++)
                {
                    List<int> arr = new List<int>();
                    for (int j = 0; j < GeneratorMartix.ColumnSize; j++)
                    {
                        arr.Add(matrix[i, j]);
                    }
                    if (i % 2 == 0)
                    {
                        arr.Sort();
                        for (int j = 0; j < GeneratorMartix.ColumnSize; j++)
                        {
                            matrix[i, j] = arr[j];
                        }
                    }
                    else
                    {
                        arr.Sort();
                        arr.Reverse();
                        for (int j = 0; j < GeneratorMartix.ColumnSize; j++)
                        {
                            matrix[i, j] = arr[j];
                        }
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            var matrix = GeneratorMartix.GetMatrix();
            GeneratorMartix.Print(matrix);
            MatrixHelper.sort_arr(matrix);
            Console.WriteLine();
            GeneratorMartix.Print(matrix);
        }
    }
}
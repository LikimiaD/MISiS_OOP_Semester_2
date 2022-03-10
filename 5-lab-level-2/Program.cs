/*
 * Вариант: 22
 * Уровень: 2
 */
namespace Level_2
{
    public class Program
    {
        internal static class GeneratorMartix
        {
            private static readonly Random generator = new Random();
            public const int RowSize = 7;
            public const int ColumnSize = 5;
            public static int[,] GetMatrix()
            {
                var matrix = new int[RowSize, ColumnSize];
                for (var i = 0; i < RowSize; i++)
                    for (var j = 0; j < ColumnSize; j++)
                        matrix[i, j] = generator.Next(-10,10);
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
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Русская локализация
            var matrix = GeneratorMartix.GetMatrix();
            GeneratorMartix.Print(matrix);
            negative_array(matrix);
        }
        public static void negative_array(int[,] matrix)
        {
            List<int> neg_arr = new List<int> ();
            List<int> max_neg_row_arr = new List<int> ();
            for (var i = 0; i < GeneratorMartix.RowSize; i++)
            {
                int neg_value = 0;
                for (var j = 0; j < GeneratorMartix.ColumnSize; j++)
                    if (matrix[i, j] < 0)
                    {
                        neg_arr.Add(matrix[i, j]);
                        neg_value = matrix[i, j];
                    }
                max_neg_row_arr.Add(neg_value);
            }
            Console.WriteLine("All negatives num"); neg_arr.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine("\nThe largest negative value in the line"); max_neg_row_arr.ForEach(i => Console.Write("{0} ", i));
        }
    }
}
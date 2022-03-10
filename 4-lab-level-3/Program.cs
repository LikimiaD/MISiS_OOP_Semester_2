/*
 * Вариант: 8
 * Уровень: 3
 */
namespace Level_3
{
    internal static class GeneratorMartixSevenOnFive
    {
        private static readonly Random generator;
        public const int RowSize = 7;
        public const int ColumnSize = 5;
        static GeneratorMartixSevenOnFive()
        {
            generator = new Random();
        }
        public static int[,] GetMatrix()
        {
            var matrix = new int[RowSize, ColumnSize];
            for (var i = 0; i < RowSize; i++)
                for (var j = 0; j < ColumnSize; j++)
                    matrix[i, j] = generator.Next(10);
            return matrix;
        }
    }
    public static class MatrixHelper
    {
        public static IEnumerable<int> GetNumberRowMatrix(this int[,] matrix, int rowIndex, int columnSize)
        {
            var rows = new List<int>();
            for (var i = 0; i < columnSize; i++)
                rows.Add(matrix[rowIndex, i]);
            return rows;
        }
        public static void Write(this int[,] matrix, int rowSize, int columnSize)
        {
            Console.WriteLine();
            for (var i = 0; i < rowSize; i++)
            {
                for (var j = 0; j < columnSize; j++)
                    Console.Write(" {0} ", matrix[i, j]);
                Console.Write(Environment.NewLine);
            }
            Console.WriteLine();
        }
    }

    public class ExtremumElement
    {
        public int RowIndex { get; set; }
        public int Value { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var nonSortedMatrix = GeneratorMartixSevenOnFive.GetMatrix();
            nonSortedMatrix.Write(GeneratorMartixSevenOnFive.RowSize, GeneratorMartixSevenOnFive.ColumnSize);

            var extremums = new List<ExtremumElement>();
            for (var i = 0; i < GeneratorMartixSevenOnFive.RowSize; i++)
            {
                var rows = nonSortedMatrix.GetNumberRowMatrix(i, GeneratorMartixSevenOnFive.ColumnSize);
                var minElement = rows.Min();
                extremums.Add(new ExtremumElement { RowIndex = i, Value = minElement });
            }

            var sortedExtremum = extremums.OrderBy(e => e.Value);

            var sortedMatrix = new int[GeneratorMartixSevenOnFive.RowSize, GeneratorMartixSevenOnFive.ColumnSize];
            var rowIndex = 0;
            foreach (var se in sortedExtremum)
            {
                for (var i = 0; i < GeneratorMartixSevenOnFive.ColumnSize; i++)
                    sortedMatrix[rowIndex, i] = nonSortedMatrix[se.RowIndex, i];
                rowIndex++;
            }
            sortedMatrix.Write(GeneratorMartixSevenOnFive.RowSize, GeneratorMartixSevenOnFive.ColumnSize);
        }
    }
}
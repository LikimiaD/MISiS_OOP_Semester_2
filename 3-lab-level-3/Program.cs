using System;
using System.Collections.Generic;
using System.Linq;

// Задание 8
namespace level_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int n = 7;
            int[] a = new int[n] { -4, -7, -9, 10, -3, 12, -8 };
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] < 0)
                {
                    int amin = a[i];
                    int imin = i;
                    for (int j = i + 1; j < n; j++)
                    {

                        if (a[j] < amin)
                        {
                            amin = a[j];
                            imin = j;
                        }
                    }
                    a[imin] = a[i];
                    a[i] = amin;
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write("{0:d} ", a[i]);
            Console.ReadKey();
        }
    }
}
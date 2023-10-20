using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diveСSharp
{
//    Дан двумерный массив.
//732
//496
//185
//Отсортировать данные в нем по возрастанию.
//123
//456
//789
//Вывести результат на печать. 
    public class Dz2
    {
        

        public static void SortArray()
        {
            int[,] a = { { 7, 3, 2 },
                         { 4, 9, 6 },
                         { 1, 8, 5 } 
            };

            int rowCount = a.GetLength(0);
            int colCount = a.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[] array = new int[rowCount * colCount];
            int index = 0;
            foreach (var item in a)
            {
                array[index] = item;
                index++;
            }

            Array.Sort(array);
            int[,] aSort = new int[rowCount, colCount];
            index = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    aSort[i,j] = array[index];
                    index++;
                    Console.Write(aSort[i,j] + " ");

                }
                Console.WriteLine();
            }                                    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8WithZeroes
{
    internal class Program
    {
        public static int[,] GetRandomTable()
        {
            Random random = new Random();
            int[,] Table = new int[3, 3];
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    Table[i, j] = random.Next(-5, 2);
                }
            }
            return Table;
        }
        public static void PrintTable(int[,] Table)
        {
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    Console.Write(Table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            bool isSimular = true;
            int countRows = 0;
            int countCols = 0;
            int[,] MyTable = GetRandomTable();
            PrintTable(MyTable);
            for (int k = 0; k < MyTable.GetLength(0) && k < MyTable.GetLength(1); k++)
            {

                for (int i = 0; i < MyTable.GetLength(0); i++)
                {

                    if (MyTable[i, k] != 0)
                    {
                        countRows++;
                    }

                }
                for (int j = 0; j < MyTable.GetLength(1); j++)
                {

                    if (MyTable[k, j] != 0)
                    {
                        countCols++;
                    }

                }
                if (countCols != countRows)
                {
                    isSimular = false;
                }
            }
            Console.WriteLine(isSimular);

        }
    }
}

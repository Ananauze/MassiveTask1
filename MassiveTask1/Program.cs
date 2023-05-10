using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Random randomForArrey = new Random();
            int stringsInArrey = 5;
            int columnsInArrey = 5;
            int minNumberInArrey = 1;
            int maxNumberInArrey = 20;
            int[,] numbersArray = new int[stringsInArrey, columnsInArrey];
            int fisrtColumnProduct = 1;
            int secondStringSumm = 0;
            int stringToSearch = 0;
            int rowToSearch = 1;

            for (int i = 0; i < numbersArray.GetLength(0); i++) 
            {
                for (int j = 0; j < numbersArray.GetLength(1); j++) 
                {
                    numbersArray[i, j] = randomForArrey.Next(minNumberInArrey, maxNumberInArrey);
                    Console.Write(numbersArray[i, j] + "  ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbersArray.GetLength(0); i++) 
            {
                fisrtColumnProduct *= numbersArray[i, stringToSearch];
            }

            for (int j = 0; j < numbersArray.GetLength(1); j++) 
            {
                secondStringSumm += numbersArray[rowToSearch, j];
            }

            Console.WriteLine($"Произведение все чисел в первом столбце - {fisrtColumnProduct}");
            Console.WriteLine($"Сумма всех чисел во второй строке - {secondStringSumm}");
        }
    }
}

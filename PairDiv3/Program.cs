using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairDiv3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// Домашняя работа Безукладникова Даниила
            ///
            /// Дан целочисленный массив из 20 элементов. 
            /// Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
            /// Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
            /// В данной задаче под парой подразумевается два подряд идущих элемента массива. 
            /// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
            ///
            Console.WriteLine("Программа по поиску пар в массиве которые нацело делятся на 3");
            int lenght = 10;
            int[] arr = new int[lenght];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < lenght; i++)
            {
                bool ok = Int32.TryParse(Console.ReadLine(), out arr[i]);
                if (!ok)
                {
                    Console.WriteLine("Введен не подходящий тип данных, поставленно значение по умолчанию 0");
                    arr[i] = 0;
                }
            }
            int countPair = 0;
            Console.WriteLine("Введенный массив:");
            for (int i = 0; i < lenght; i++)
            {
                if (i != lenght - 1) 
                { 
                    if ((arr[i] % 3 == 0) || (arr[i + 1] % 3 == 0)) countPair++; 
                } 
                Console.Write($" {arr[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Кол-во пар чисел в массиве которые нацело делятся на 3: {countPair}");
            Console.ReadKey();
        }
    }
}

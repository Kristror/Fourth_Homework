using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimArray
{
    partial class Program
    {

        static void Main(string[] args)
        {
            ///
            /// Домашняя работа Безукладникова Даниила
            ///
            /// а) Дописать класс для работы с одномерным массивом. 
            /// Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
            /// Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива,
            /// метод Multi, умножающий каждый элемент массива на определенное число, 
            /// свойство MaxCount, возвращающее количество максимальных элементов. 
            /// В Main продемонстрировать работу класса.
            /// б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            ///
            Console.WriteLine("Программа по работе с одномерным массивом");
            Console.WriteLine("Введите длинну массива:");
            int length = 0;
            Int32.TryParse(Console.ReadLine(), out length);
            Console.WriteLine("Введите начальное значение элемента массива:");
            int firstElem = 0;
            Int32.TryParse(Console.ReadLine(), out firstElem); 
            Console.WriteLine("Введите шаг:");
            int step = 0;
            Int32.TryParse(Console.ReadLine(), out step);
            Console.ReadKey();
            OneArray arr = new OneArray(length, firstElem, step);
        }
    }
}

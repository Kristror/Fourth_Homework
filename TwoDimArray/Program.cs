using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// Домашняя работа Безукладникова Даниила
            ///
            /// *а) Реализовать класс для работы с двумерным массивом.
            /// Реализовать конструктор, заполняющий массив случайными числами.
            /// Создать методы, которые возвращают сумму всех элементов массива,
            /// сумму всех элементов массива больше заданного,
            /// свойство, возвращающее минимальный элемент массива, 
            /// свойство, возвращающее максимальный элемент массива, 
            /// метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
            /// *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            /// Дополнительные задачи
            /// в) Обработать возможные исключительные ситуации при работе с файлами.
            ///
            Console.WriteLine("Программа по работе с одномерным массивом");
            Console.WriteLine("Сгенирировать новый массив (0) или открыть существующий (1)");
            int type = 0;
            Int32.TryParse(Console.ReadLine(), out type);
            TwoArray arr = null;
            if (type == 0)
            {
                Console.WriteLine("Генерация нового массива:");
                Console.WriteLine("Введите высоту массива:");
                int row = 0;
                Int32.TryParse(Console.ReadLine(), out row);
                Console.WriteLine("Введите ширину массива:");
                int colls = 0;
                Int32.TryParse(Console.ReadLine(), out colls);
                arr = new TwoArray(row, colls, false);

                Console.WriteLine("Сгенерированный массив:");
                arr.Save("text.txt");
            }
            else if(type == 1)
            {                
                if (!TwoArray.Load(ref arr,"text.txt")) 
                {
                    Console.WriteLine("Не существует файла с сохранненым массивом. Выход из программы");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Открытый массив:");
            }
            arr.Print();
            Console.WriteLine($"Сумма элементов массива: {arr.Summ()}");
            Console.WriteLine("Введите число элементы больше которого будут использованны для вычисления суммы массива:");
            int num = 0;
            Int32.TryParse(Console.ReadLine(), out num);
            Console.WriteLine($"Сумма элементов массива больше {num}: {arr.Summ(num)}");
            Console.WriteLine($"Минимальный элемент массива: {arr.Min}"); 
            Console.WriteLine($"Максимальный элемент массива: {arr.Max}");
            int rowP = 0;
            int colP = 0;
            arr.MaxPos(ref rowP, ref colP);
            Console.WriteLine($"Максимальный элемент массива находится в {rowP+1} строке, в {colP+1} столбце.");

            Console.ReadKey();
        }
    }
}

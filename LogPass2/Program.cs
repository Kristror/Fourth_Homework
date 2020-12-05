using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogPass2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ///
            /// Домашняя работа Безукладникова Даниила
            ///
            /// Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
            /// Создайте структуру Account, содержащую Login и Password.
            ///
            string path = "acc.txt";
            Account acc = new Account();
            acc.Load(path);

            int attempts = 3;
            bool authorization = false;
            Console.WriteLine("Программа для проверки логина и пароля");

            while (attempts > 0)
            {
                authorization = acc.Authorizations();
                if (authorization) break;
                else
                {
                    attempts--;
                    Console.WriteLine($"Ввенные логин и пароль не подходят осталось {attempts} попыток");
                }
            };
            if (authorization) Console.WriteLine("Вы успешно вошли в систему");
            else Console.WriteLine("Вы превысили кол-во попыток для входа в систему");
            Console.ReadKey();
        }
    }
}

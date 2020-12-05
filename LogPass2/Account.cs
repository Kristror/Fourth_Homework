using System;
using System.IO;

namespace LogPass2
{
    partial class Program
    {
        struct Account
        {
            private string login;
            private string password;

            public void Load(string path)
            {
                string[] str = File.ReadAllLines(path);
                login = str[0];
                password = str[1];
            }
            public bool Authorizations()
            {
                Console.WriteLine("Введите логин:");
                string inLog = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string inPass = Console.ReadLine();

                if ((inLog == login) && (inPass == password)) return true;
                else return false;
            }
        }
    }
}

// Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.
//Плескач
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyMethods.Methods;

namespace Solution_4
{
    class Program
    {
        const string trueLogin = "root";
        const string truePassword = "GeekBrains";        
        static bool Authorization(string login, bool password)
        {
            if (login == trueLogin && password)
                return true;
            return false;
        }
        static string LoginCheck()
        {
            string login;
            do
            {
                Console.WriteLine("Введите логин: ");
                login = Console.ReadLine();
                if (login == trueLogin)
                    return login;
                Print("Такого логина не существует! повторите ввод", ConsoleColor.Red);
            } while (login != trueLogin);
            return "";
        }
        /// <summary>
        /// Проверка пароля. Принимает количество проверок(по умолчанию 5).
        /// Возвращает true в случае успеха и false при исчерпании попыток ввода.
        /// </summary>
        /// <param name="tryCount"></param>
        /// <returns></returns>
        static bool PasswordCheck(int tryCount = 5)
        {
            const string exept = "Превышена максимальная длинна пароля или нажата клавиша 'Escape'. Повторите Ввод...";
            const int passLength = 10;
            string str;                        
            do
            {
                Console.WriteLine("\nВведите пароль:");
                str = PasswordEnter(exept, passLength);
                if (str == exept)
                    continue;
                if (str == truePassword)
                    return true;
                tryCount--;
                Print("Неверный пароль. Осталось попыток: " + tryCount, ConsoleColor.Red);
            } while (tryCount > 0);
            return false;
        }
        /// <summary>
        /// Ввод пароля с сокрытием вводимых символов.
        /// Также при превышении длинны пароля или нажатия клавиши 'Escape' ввод пароля прерывается и метод возвращает переданное сообщение.
        /// Передаем сообщение и макс длинну пароля(по умолчанию 20).
        /// </summary>
        /// <returns></returns>
        private static string PasswordEnter(string exept, int maxLength = 20)
        {            
            string password = "";            
            while (password.Length <= maxLength)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);                
                if (key.Key == ConsoleKey.Enter)
                    return password;
                if (key.Key == ConsoleKey.Escape)
                    break;
                if (password.Length > 0 && key.Key == ConsoleKey.Backspace || key.Key == ConsoleKey.Delete)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
                if (char.IsLetterOrDigit(key.KeyChar))
                {
                    password += key.KeyChar;
                    Console.Write('*');
                }
            }
            Print(exept, ConsoleColor.Red);
            return exept;
        }

        static void Main(string[] args)
        {
            int tryCount = 3;
            Print("Для входа введите логин и пароль", ConsoleColor.Cyan);
            string login = LoginCheck();
            bool password = PasswordCheck(tryCount);
            Console.Clear();
            if (Authorization(login, password))
            {
                Print("Добро пожаловать! " + login, ConsoleColor.Green); ;
                Pause();
            }
            else
            {
                Print("Все попытки исчерпаны. Авторизация не пройдена!", ConsoleColor.Red);
                Pause();
            }
            
        }
    }
}

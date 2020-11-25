using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    //1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
    //Плескач
    class Program : MyMethods
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age;
            double height, weight;
            Console.WriteLine("Программа \"Анкета\"");
            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            surname = Console.ReadLine();
        #region Parse trying
        TryAge:
            try
            {                
                Console.WriteLine("Введите ваш возраст:");
                age = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Print("Не удалось определить возраст, попробуйте ввести целое число без пробелов", ConsoleColor.Red);
                goto TryAge;
            }
        TryHeight:
            try
            {
                Console.WriteLine("Введите ваш рост:");
                height = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Print("Не удалось определить рост, попробуйте использовать в качестве разделителя ',' либо введите целое число", ConsoleColor.Red);
                goto TryHeight;
            }
        TryWeigth:
            try
            {
                Console.WriteLine("Введите ваш вес:");
                weight = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Print("Не удалось определить вес, попробуйте использовать в качестве разделителя ',' либо введите целое число", ConsoleColor.Red);
                goto TryWeigth;
            }
            #endregion
            Pause();
            Console.Clear();

            //а) используя склеивание;            
            Print("Имя: " + name + " \tФамилия: " + surname + "\nВозраст: " + age + " \tРост: " + height + " \tВес: " + weight, ConsoleColor.Magenta);
            
            //б) используя форматированный вывод;          
            Print(String.Format("Имя: {0}\tФамилия: {1}\nВозраст: {2}\tРост: {3:F2}\tВес: {4:F2}", name, surname, age, height, weight), ConsoleColor.DarkGreen);

            //в) *используя вывод со знаком $;            
            Print($"Имя: {name}\tФамилия: {surname}\nВозраст: {age}\tРост: {height:F2}\tВес: {weight:F2}", ConsoleColor.Yellow);
            Console.WriteLine();
            Pause("Нажмите любую клавишу для завершения...", ConsoleColor.Cyan);
        }
    }
}

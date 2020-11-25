using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    class Program5
    {
        static void Main(string[] args)
        {
            //б) Сделать задание, только вывод организуйте в центре экрана
            Print("Домашние задания выполнены:", Console.WindowWidth/2, Console.WindowHeight/2);
            Print("Пётр Плескач г.Таганрог", Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
            Console.ReadKey();
        }
        //в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
        static void Print(string str, int x, int y)
        {
            Console.SetCursorPosition(x - (str.Length/2), y); ;
            Console.WriteLine(str);
        }
    }
}

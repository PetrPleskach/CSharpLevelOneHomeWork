//Написать метод, возвращающий минимальное из трёх чисел.
//Плескач
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyMethods.Methods;

namespace Solution_1
{
    class Program
    {
        static double MinimumFromThree(double a, double b, double c)
        {
            return (a < b) ? ((a < c) ? a : (c < b) ? c : b) : (b < c) ? b : c;
        }
        static void Main(string[] args)
        {            
            Console.WriteLine("Программа для вывода минимального числа из трёх.\nВведите последовательно три числа.");            
            double firstNum = DoubleInputCheсk("Введите первое число:");            
            double secondNum = DoubleInputCheсk("Введите второе число:");            
            double thridNum = DoubleInputCheсk("Введите третье число:");
            Console.Clear();
            Print($"Наименьшее из чисел: {firstNum}, {secondNum}, {thridNum}.");
            Print($"Это - {MinimumFromThree(firstNum, secondNum, thridNum)}", ConsoleColor.Green);

            Pause();            
        }
    }
}

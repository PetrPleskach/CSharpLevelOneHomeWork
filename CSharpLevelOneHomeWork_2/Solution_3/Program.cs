//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
//Плескач
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyMethods.Methods;

namespace Solution_3
{
    class Program
    {
        static bool PositiveOddNumberCheck(int num)
        {
            if (num > 0 && num % 2 != 0)
                return true;
            return false;
        }        
        static void Main(string[] args)
        {
            Print("Программа для подсчета нечётных положительных чисел.", ConsoleColor.Cyan);
            Print("Вводите числа последовательно нажимая 'Enter'.\nДля остановки ввода и подсчёта суммы введите '0'");
            bool notZero = true;
            int num;
            int sum = 0;
            while (notZero)
            {
                num = IntInputCheck();
                if (num == 0)
                    notZero = false;
                if (PositiveOddNumberCheck(num))
                    sum += num;
                Console.WriteLine("Для остановки ввода и подсчёта суммы введите '0'");
            }
            Console.Clear();
            Print("Сумма введённых нечётных положительный чисел - " + sum, ConsoleColor.Green);
            Pause();
        }
    }
}

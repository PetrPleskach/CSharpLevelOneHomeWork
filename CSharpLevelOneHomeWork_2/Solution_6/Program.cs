//6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр.
//Реализовать подсчет времени выполнения программы, используя структуру DateTime.
//Плескач
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyMethods.Methods;
using static System.Console;

namespace Solution_6
{
    class Program
    {
        static bool IsGoodNumber(int num)
        {
            bool isGood = false;
            int sum = 0;
            for (int i = num; i > 0  ; i /= 10)            
                sum += i % 10;
            if (num % sum == 0)
                isGood = true;
            return isGood;
        }
        static void Main(string[] args)
        {
            Print("Программа подсчёта чисел Нивена. Работа программы может занять некоторое время наберитесь терпения...", ConsoleColor.Cyan);
            int maxValue = 1_000_000_000;
            int count = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i <= maxValue; i++)
            {
                if (IsGoodNumber(i))
                    count++;
                if(i % 25_000_000 == 0 && i != maxValue)
                    Print($"Проверено чисел: {i:#,#}. Из них чисел Нивена: {count:#,#}", ConsoleColor.Yellow);
            }
            Clear();
            Print("Подсчёт закончен!", ConsoleColor.Cyan);
            Write("Затрачено времени: ");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(DateTime.Now - start);
            ResetColor();
            Write("Чисел Нивена обнаружено: ");
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"{count:#,#}");
            Pause();
        }
    }
}

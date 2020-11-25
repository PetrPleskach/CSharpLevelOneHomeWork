using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution_3;

namespace Solution_4
{
    //Написать программу обмена значениями двух переменных.
    //Плескач
    class Program4 : Program3
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, swapHelper;
            Console.WriteLine("Программа для обмена значений между двумя переменными");
            Console.WriteLine("Введите значение первой переменной:");
            firstValue = InputCheck();
            Console.WriteLine("Введите значение второй переменной:");
            secondValue = InputCheck();            
            Console.WriteLine($"Введённые переменные: \nПервая - {firstValue:F2}\nВторая - {secondValue:F2}");
            //а) с использованием третьей переменной;
            swapHelper = firstValue;
            firstValue = secondValue;
            secondValue = swapHelper;
            Console.WriteLine($"Они поменялись: \nПервая - {firstValue:F2}\nВторая - {secondValue:F2}");
            //б) *без использования третьей переменной.
            firstValue += secondValue;
            secondValue = firstValue - secondValue;
            firstValue -= secondValue;
            Console.WriteLine($"И вернулись обратно: \nПервая - {firstValue:F2}\nВторая - {secondValue:F2}");
            Pause("Нажмите любую клавишу чтобы закрыть программу...");
        }
    }
}

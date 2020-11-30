//7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
//Плескач
using System;
using static MyMethods.Methods;

namespace Solution_7
{
    class Program
    {
        static void FromAToB(byte a, byte b)
        {
            if (a <= b)
            {
                if(Console.CursorLeft > Console.WindowWidth - 5)
                    Console.WriteLine();
                Console.Write("{0:000} ", a);
                System.Threading.Thread.Sleep(50);
                if (a != b)
                    FromAToB(++a, b);
            }
            else return;
        }
        static int SumFromAToB(byte a, byte b)
        {
            int sum = 0;
            if (a == b)
                return b;
            if (a < b)
                sum = a  + SumFromAToB(++a , b);
            return sum;
        }
        static void Main(string[] args)
        {
            byte a, b; //тип byte используется чтобы избежать StackOwerflowExeption.            
            Print("Программа для вывода чисел в диапазоне от 0 до 255 и подсчёта их суммы", ConsoleColor.Cyan);
            #region ***Ввод чисел и проверка граничных значений***
            a = ByteInputCheck("Введите первое число");
            b = ByteInputCheck("Введите второе число. Должно быть больше первого");
            if (b == byte.MinValue)
            {
                b = byte.MaxValue;
                Print("Т.к. второму числу было задано минимально возможное значение оно заменено на максимальное!", ConsoleColor.Red);
            }
            if (a >= b)            
                Console.WriteLine("Второе число меньше либо равно первому!");
            while (a >= b)            
                a = ByteInputCheck("Введите число меньше: " + b);
            #endregion
            Console.WriteLine("Вывод чисел:");
            FromAToB(a, b);
            Print($"Сумма всех чисел в диапазоне от {a} до {b}, равна: {SumFromAToB(a, b)}", ConsoleColor.DarkGreen);
            Pause();
        }
    }
}

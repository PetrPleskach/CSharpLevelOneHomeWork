//Написать метод подсчета количества цифр числа.
//Плескач
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyMethods.Methods;

namespace Solution_2
{
    class Program
    {
        static int NumberOfDigitsInNumber(int num)
        {
            int sum = 0;
            do
            {
                num /= 10;
                sum++;
            } while (num != 0);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подсчета количества цифр в числе");
            int num = IntInputCheck("Введите число:");
            Console.WriteLine($"Количество цифр в числе - {NumberOfDigitsInNumber(num)}");
            Pause();
        }
    }
}

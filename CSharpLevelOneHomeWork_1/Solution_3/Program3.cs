using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution_1;

namespace Solution_3
{
    //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
    //Плескач
    public class Program3 : MyMethods
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Программа для рассчета растояния между точками по двум координатам");
            Console.WriteLine("Введите координату 'x' первой точки:");
            x1 = InputCheck();
            Console.WriteLine("Введите координвту 'y' первой точки:");
            y1 = InputCheck();
            Console.WriteLine("Введите координату 'x' второй точки:");
            x2 = InputCheck();
            Console.WriteLine("Введите координату 'y' второй точки:");
            y2 = InputCheck();
            Console.Clear();
            Print($"Расстояние между двумя точками: {DistanceBetweenTwoPoints(x1, y1, x2, y2):F2}", ConsoleColor.DarkGreen);
            Pause("Нажмите любую клавишу чтобы закрыть программу...", ConsoleColor.Yellow);
        }
        public static double InputCheck()
        {
        InputTry:
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Print("Не удалось определить значение, попробуйте использовать в качестве дробного разделителя ',' либо введите целое число", ConsoleColor.Red);
                goto InputTry;
            }
        }

        //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
        static double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}

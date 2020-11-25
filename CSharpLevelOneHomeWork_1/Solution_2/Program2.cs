using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solution_1;

namespace Solution_2
{
    //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах
    //Плескач
    class Program2 : MyMethods
    {        
        static void Main(string[] args)
        {            
            double BMI, height, weight;
            Console.WriteLine("Программа для расчета ИМТ(индекс массы тела)");
        TryHeight:
            try
            {
                Console.WriteLine("Введите ваш рост в метрах:");
                height = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Print("Не удалось определить рост, попробуйте использовать в качестве разделителя ','", ConsoleColor.Red);
                goto TryHeight;
            }
        TryWeigth:
            try
            {
                Console.WriteLine("Введите ваш вес в килограммах:");
                weight = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Print("Не удалось определить вес, попробуйте использовать в качестве разделителя ',' либо введите целое число", ConsoleColor.Red);
                goto TryWeigth;
            }
            
            BMI = (weight / (height * height));
            Console.Clear();
            if (BMI > 16 && BMI < 25)
                Print($"Ваш индекс массы тела: {BMI:F2}(Нормальный)", ConsoleColor.DarkGreen);
            else if (BMI < 16 && BMI > 0)
                Print($"Ваш индекс массы тела: {BMI:F2}(Недостаточный)", ConsoleColor.DarkBlue);
            else if (BMI > 25)
                Print($"Ваш индекс массы тела: {BMI:F2}(Избыточный)", ConsoleColor.DarkRed);
            else
                Print($"Возникла ошибка возможно деление на ноль или отрицательное число", ConsoleColor.Yellow);
            Pause("Нажмите любую клавишу для завершения...", ConsoleColor.Cyan);

        }
    }
}

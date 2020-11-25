using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    //6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
    public class MyMethods
    {
        public static void Print(string msg, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine();
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        public static void Pause(string msg = "Нажмите любую клавишу чтобы продолжить...", ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;            
            Console.WriteLine(msg);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMethods
{
    public class Methods
    {
        public static void Print(string msg, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;            
            Console.WriteLine("\n" + msg);
            Console.ResetColor();
        }

        public static void Pause(string msg = "Работа программы завершена, нажмите любую клавишу чтобы закрыть консоль...", ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// Парсит ввод с консоли в ДАБЛ. Можно передать сообщение для отображения перед вводом.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static double DoubleInputCheсk(string msg = "")
        {            
            while (true)
            {
                if(msg != "")
                    Console.WriteLine(msg);
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Print("Не удалось распознать число! используйте ',' в качестве дробного разделителя или попробуйте ввести целое число...", ConsoleColor.Red);                    
                }
            }            
        }
        /// <summary>
        /// Парсит ввод с консоли в ИНТ. Можно передать сообщение для отображения перед вводом.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static int IntInputCheck(string msg = "")
        {
            while (true)
            {
                if(msg != "")
                    Console.WriteLine(msg);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Print("Не удалось распознать число! Попробуйте ввести целое число...", ConsoleColor.Red);
                }
            }
        }        
        /// <summary>
        /// Парсит ввод с консоли в БАЙТ. Можно передать сообщение для отображения перед вводом.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static byte ByteInputCheck(string msg = "")
        {
            while (true)
            {
                if (msg != "")
                    Console.WriteLine(msg);
                try
                {
                    return byte.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Print("Не удалось распознать число! Попробуйте ввести целое число в диапазоне от 0 до 255", ConsoleColor.Red);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firetruck.Utils
{
    internal class firetruckOutput
    {
        public static void err(string err, string at) 
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"    ... ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{at} :. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(err+"\n");
        }
        public static void errinfo(string err)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[info] ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(err + "\n");
        }
        public static void warn(string warning, string at)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"    ... ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{at} :. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(warning + "\n");
        }
        public static void warninfo(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[info] ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(warning + "\n");
        }
        public static void stdout(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[info] ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(warning + "\n");
        }
        public static void result(string warning)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("[result] ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(warning + "\n");
        }
    }
}

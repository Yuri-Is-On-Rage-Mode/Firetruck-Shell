using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace firetruck.Utils
{
    public class InputUtils
    {

        public static int WhatTypeIsThis(string thing)
        {
            int retu = 0;

            if (thing == null) return 696969;
            if (thing.Contains("/") || thing.Contains("\\"))
            {
                retu = ProcessLenOfThis(thing);
            }
            else if (thing.Contains("@") || thing.Contains("$"))
            {
                retu = ProcessLenOfThis(thing);
            }
            return retu;
        }

        public static string FurtherProcessThisPlease(string text)
        {
            return PleaseShortenThis(text);
        }

        public static int ProcessLenOfThis(string thing)
        {
            int ret = 0;

            if (thing.Length >= 9)
            {
                ret = 1;
            }

            return ret;
        }

        public static string PleaseShortenThis(string thing)
        {
            string shortenText = "";

            if (thing.Length >= 19)
            {
                for (int i = 0; i < 3; i++)
                {
                    shortenText = shortenText + thing[i];
                }


                if ((thing.Length - 4) >= 5)
                {
                    int do_it = 0;
                    for (int c = 0; c < 14; c++)
                    {
                        if (do_it <= 15)
                        {
                            shortenText = shortenText + ".";
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    for (int i = 4; i < (thing.Length - 4); i++)
                    {
                        shortenText = shortenText + ".";
                    }
                }
                

                for (int i = (thing.Length - 4); i < (thing.Length); i++)
                {
                    shortenText = shortenText + thing[i];
                }
            }

            return shortenText;
        }
    
    }
    internal class DesignFormat
    {
        public static void TakeInput(List<string> things)
        {

            if (things.Count >= 4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < things.Count; i++)
                {
                    int type = InputUtils.WhatTypeIsThis(things[i]);
                    if (type == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.Write(things[i]);
                    }
                    else if (type == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        string thing = InputUtils.FurtherProcessThisPlease(things[i]);

                        Console.Write(thing);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write(things[i]);
                    }
                }
                //Console.WriteLine();
                //for (int i = 3; i < things.Count; i++)
                //{
                //    Console.ForegroundColor = ConsoleColor.Cyan;

                //    Console.Write(things[i]);

                //}

                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    if (things[i].Contains("@"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(things[i]);
                    }
                    else if (things[i].Contains("!"))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(things[i]);
                    }
                    else if (things[i].Contains(":"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(things[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(things[i]);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }

        public static void Banner()
        {
            Console.WriteLine("(#) firetruck Virtual Os / Develpement Env\n" +
                              "(c) Fri3nds Enterprise (2008-2088)\n");

        }
    }
}

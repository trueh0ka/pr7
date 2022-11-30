using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace provodnik
{
    internal class Strelki
    {
        
        public static void Osnova()
        {
            Znach.position = 1;
            while(true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch(key.Key)
                {
                    case ConsoleKey.F1:
                        {
                            Console.SetCursorPosition(0, Znach.position);
                            Console.Write("=>");
                            Console.Clear();
                            Console.WriteLine("--------------------Проводник--------------------");
                            Otkritie.Diski();
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Znach.position != Znach.max)
                        {
                            Console.SetCursorPosition(0, Znach.position);
                            Console.WriteLine("  ");
                            Znach.position++;
                            Console.SetCursorPosition(0, Znach.position);
                            Console.Write("=>");
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Znach.position != Znach.min)
                        {
                            Console.SetCursorPosition(0, Znach.position);
                            Console.WriteLine("  ");
                            Znach.position--;
                            Console.SetCursorPosition(0, Znach.position);
                            Console.Write("=>");
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            Console.Clear();
                            Otkritie.Papki();
                        }
                        break;
                    case ConsoleKey.Backspace:
                        {
                            Console.Clear();
                            Otkritie.Ochistka();
                            Program.Main();
                        }
                        break;
                    case ConsoleKey.Escape:
                        {
                            Console.Clear();
                            Process.GetCurrentProcess().Kill();
                        }
                        break;
                }
            }
        }
    }
}

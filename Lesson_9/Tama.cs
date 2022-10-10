using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
   
        class Tama
        {
            public string Name { get; set; }
            public int Dicipline { get; set; }
            public int Hungry { get; set; }
            public int Happy { get; set; }
            public int Poop { get; set; }
            public bool Good { get; set; }

            public string food;

            public string Stage { get; set; }
            ConsoleColor Color { get; set; }

            public Tama(string name)
            {
                Name = name;
                Stage = "egg";
                Color = ConsoleColor.DarkYellow;
            }

            public void WriteTama()
            {
                if (Hungry > 5)
                {
                    Poop += 1;
                    Hungry = 2;
                }

                Console.Clear();
                WriteName();
                DrawTama();
                DrawChart();

                if (Poop > 0) DrawСрать();
            }

            public void ChangeStage(string stage)
            {
                Stage = stage;

                if (Stage == "goodTeen" || Stage == "goodAdult" || Stage == "angel")
                    Good = true;
                else
                    Good = false;
            }

            public void WriteName()
            {
                Console.SetCursorPosition(7, 1);
                Console.WriteLine("  ♥  ♥  ♥  {0}  ♥  ♥  ♥", Name);
                Console.WriteLine();
            }

            public void DrawChart()
            {
                Console.SetCursorPosition(5, 17);

                Console.Write("Бухать: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (var i = 0; i < Dicipline; i++)
                {
                    Console.Write("♥");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("  Курить: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (var i = 0; i < Hungry; i++)
                {
                    Console.Write("♥");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("  Драцца: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (var i = 0; i < Hungry; i++)
                {
                    Console.Write("♥");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            public void DrawСрать()
            {
                Console.SetCursorPosition(5, 19);
                Console.Write("Срать: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (var i = 0; i < Poop; i++)
                {
                    Console.Write("▲");
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            public void DrawTama()
            {
                switch (Stage)
                {
                    case "baby":
                        Color = ConsoleColor.Magenta;
                        Baby();
                        break;
                    case "goodTeen":
                        Color = ConsoleColor.Cyan;
                        GoodTeen();
                        break;
                    case "badTeen":
                        Color = ConsoleColor.Green;
                        BadTeen();
                        break;
                    case "goodAdult":
                        Color = ConsoleColor.Blue;
                        GoodAdult();
                        break;
                    case "badAdult":
                        Color = ConsoleColor.DarkGreen;
                        BadAdult();
                        break;
                    case "angel":
                        Color = ConsoleColor.DarkCyan;
                        Angel();
                        break;
                    case "dead":
                        Color = ConsoleColor.DarkGray;
                        Dead();
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }

            public void TamaTalks(string String)
            {
                Console.ForegroundColor = Color;
                Console.WriteLine();
                Console.Write("{0}> ", Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(String);
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
            }

           
            void Baby()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                  ■ ■■■■ ■   ");
                Console.WriteLine("                ■          ■ ");
                Console.WriteLine("               ■  ■      ■  ■");
                Console.WriteLine("               ■    ■■■■    ■");
                Console.WriteLine("               ■            ■");
                Console.WriteLine("                ■          ■ ");
                Console.WriteLine("                  ■ ■■■■ ■   ");
            }

            void GoodTeen()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine();
                Console.WriteLine("                  ■ ■■■■ ■■   ");
                Console.WriteLine("                ■           ■  ");
                Console.WriteLine("               ■  ■       ■  ■ ");
                Console.WriteLine("               ■    ■■■■■    ■ ");
                Console.WriteLine("              ■■             ■■");
                Console.WriteLine("                ■           ■  ");
                Console.WriteLine("                 ■    ■    ■   ");
                Console.WriteLine("                  ■  ■ ■  ■   ");
                Console.WriteLine("                   ■     ■     ");
            }

            void BadTeen()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine();
                Console.WriteLine("                     ■ ■■■ ■      ");
                Console.WriteLine("                   ■         ■    ");
                Console.WriteLine("              ■■■■    ■   ■    ■  ");
                Console.WriteLine("             ■■■■■              ■ ");
                Console.WriteLine("                  ■            ■  ");
                Console.WriteLine("                  ■            ■  ");
                Console.WriteLine("                  ■             ■");
                Console.WriteLine("                  ■      ■       ■");
                Console.WriteLine("                    ■ ■ ■  ■ ■ ■  ");
            }

            void GoodAdult()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine("                   ■       ■     ");
                Console.WriteLine("                  ■■■■   ■■■■    ");
                Console.WriteLine("                 ■■■■■■■■■■■■■   ");
                Console.WriteLine("                 ■           ■   ");
                Console.WriteLine("                ■  ■       ■  ■  ");
                Console.WriteLine("                ■     ■■■     ■  ");
                Console.WriteLine("              ■■■             ■■■");
                Console.WriteLine("                 ■           ■   ");
                Console.WriteLine("                  ■    ■    ■    ");
                Console.WriteLine("                   ■  ■ ■  ■     ");
                Console.WriteLine("                    ■     ■      ");
            }

            void BadAdult()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine("                     ■ ■■■ ■      ");
                Console.WriteLine("                   ■         ■    ");
                Console.WriteLine("             ■■■■■    ■   ■    ■  ");
                Console.WriteLine("               ■               ■  ");
                Console.WriteLine("             ■■■■■              ■ ");
                Console.WriteLine("                  ■            ■  ");
                Console.WriteLine("                  ■            ■  ");
                Console.WriteLine("                  ■              ■");
                Console.WriteLine("                  ■      ■       ■");
                Console.WriteLine("                    ■   ■ ■   ■ ■ ");
                Console.WriteLine("                     ■      ■     ");
            }

            void Angel()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine("                     ■■■■■       ");
                Console.WriteLine("                                 ");
                Console.WriteLine("                  ■■ ■ ■ ■ ■■    ");
                Console.WriteLine("                 ■           ■   ");
                Console.WriteLine("      ■         ■  ■       ■  ■  ");
                Console.WriteLine("    ■ ■ ■       ■     ■■■     ■  ");
                Console.WriteLine("      ■         ■             ■  ");
                Console.WriteLine("      ■          ■           ■   ");
                Console.WriteLine("                   ■       ■     ");
                Console.WriteLine("                      ■ ■        ");
                Console.WriteLine("                       ■         ");
            }

            void Dead()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine("                   ■ ■ ■ ■      ");
                Console.WriteLine("                   ■     ■      ");
                Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■");
                Console.WriteLine("             ■      R.I.P.     ■");
                Console.WriteLine("             ■ ■ ■ ■     ■ ■ ■ ■");
                Console.WriteLine("                   ■     ■      ");
                Console.WriteLine("                   ■     ■      ");
                Console.WriteLine("                   ■     ■      ");
                Console.WriteLine("                   ■     ■      ");
                Console.WriteLine("                   ■     ■      ");
                Console.WriteLine("                   ■ ■ ■ ■      ");
            }
        }
    
}


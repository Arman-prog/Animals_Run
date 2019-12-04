using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Animal
{
   public class Judg
    {
        private int TimeSpeed { set; get; } = 100;
        public char Flag { set; get; } = '$';
        public Animal A1 { set; get; }
        public Animal A2 { set; get; }
        private Animal a_champion { set; get; }
        public int Distance { set; get; } = 100;
        private static string Champion { set; get; }
        private int Time { set; get; }
        

        public Judg() { }

        public Judg(Animal a1, Animal a2)
        {
            A1 = a1;
            A2 = a2;
        }

        public void DrawStation()
        {
            A1.Y = 7;
            A2.Y = A1.Y + 2;
            ForegroundColor = A1.Color;
            Console.Write(A1.Icone);
            ResetColor();
            Console.WriteLine(" is a kangaroo, his name is a " + A1.Name);
            ForegroundColor = A2.Color;
            Console.Write(A2.Icone);
            ResetColor();
            Console.WriteLine(" is a dog, his name is a " + A2.Name);

            Console.SetCursorPosition(Distance, A1.Y);
            Console.Write(Flag);
            Console.SetCursorPosition(Distance, A2.Y);
            Console.Write(Flag);

            for (int i = 0; i < Distance; i++)
            {
                for (int j = 0; j < Distance; j++)
                {
                    if (i == 0)
                    {
                        Console.SetCursorPosition(0 + j, A1.Y - 1);
                        Console.Write(".");
                        Console.SetCursorPosition(0 + j, A1.Y + 1);
                        Console.Write(".");
                        Console.SetCursorPosition(0 + j, A2.Y + 1);
                        Console.Write(".");
                    }

                }
            }
            SetCursorPosition(0, 3);
            Console.WriteLine("Who will win races?");
            Console.WriteLine("press ENTER to start");
            string start = ReadLine();
            //Thread.Sleep(500);
        }

        public void Draw(DrawOrClear dr = DrawOrClear.Draw)
        {
           
            A1.Y = 7;
            A2.Y = A1.Y + 2;
            A1.Draw(dr);
            A2.Draw(dr);
           
        }
        
        public void Run()
        {            
            A1.X = A2.X = 0;
            Console.Clear();
            DrawStation();
            Time = 0;
            while (A1.X<Distance&&A2.X<Distance)
            {
                Draw();
                Thread.Sleep(TimeSpeed);
                Draw(DrawOrClear.Clear);
                A1.Move();
                A2.Move();
                Time += TimeSpeed;
            }
            
           a_champion= A1.X >= Distance ? A1: A2;
            Champion = a_champion.Name;
            PrintText();

        }
        public void PrintText()
        {
            string text = $"Champion is a {Champion}. His Time is {Time/1000} sec";
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2);
            Console.ForegroundColor = a_champion.Color;
            Console.WriteLine(text);
            Console.ResetColor();
            Console.WriteLine('\a');
            Console.WriteLine("press Enter for new game");
            if (Console.ReadKey().Key==ConsoleKey.Enter)
            {
                Run();
            }


        }



    }
}

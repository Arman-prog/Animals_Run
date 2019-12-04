using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public enum DrawOrClear { Draw,Clear}
   public abstract class Animal
    {
        public string Name { set; get; } = "Animal";
        public ConsoleColor Color { set; get; } = ConsoleColor.Yellow;
        public int X { set; get; }
        public int Y { set; get; }
        public char Icone { set; get; }
        public static Random Rand { set; get; } = new Random();

        public Animal()
        {

        }
       
        public void Draw(DrawOrClear dc=DrawOrClear.Draw)
        {
            Console.ForegroundColor = dc == DrawOrClear.Draw ? Color : Console.BackgroundColor;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Icone);
            Console.ResetColor();
        }

        public abstract void Move();



    }
}

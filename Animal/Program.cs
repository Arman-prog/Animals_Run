using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pit = new Dog()
            {
                Color = ConsoleColor.Yellow,
                Icone = '@',
                Name = "Pit"
            };
            Kenguru bob = new Kenguru()
            {
                Color = ConsoleColor.Green,
                Icone = 'K',
                Name = "Bob"
            };

            Judg judg = new Judg(bob, pit)
            {
                Distance=100,
                Flag='!'
            };                      

            judg.Run();

        }
    }
}

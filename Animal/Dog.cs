using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   public class Dog: Animal
    {
        public Dog()
        {

        }
       
        public override void Move()
        {
            int n=Rand.Next(101);
            if (n<=20)
            {
                X += 3;
            }
            else if (n<=45)
            {
                X ++;
            }
            else if (n<=60)
            {
                X -= 2;
            }
            else if (n<=80)
            {
                X--;
            }
            if (X<0)
            {
                X = 0;
            }
            else if (X>Console.WindowWidth)
            {
                X = Console.WindowWidth - 1;
            }
            
        }





    }
}

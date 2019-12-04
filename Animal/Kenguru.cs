using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
   public class Kenguru: Animal
    {
        public Kenguru()
        {

        }
       

        public override void Move()
        {
            int n = Rand.Next(101);
            if (n<=15)
            {
                X += 5;
            }
            else if (n<=30)
            {
                X += 2;
            }
            else if (n<=50)
            {
                X -= 3;
            }
            else if (n<=70)
            {
                X--;
            }
            else if (n<=80)
            {
                X++;
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

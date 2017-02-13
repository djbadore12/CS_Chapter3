using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like Oak, Pine, or Mahogony?");
            String wood = Console.ReadLine();
            int pine = 100;
            int oak = 225;
            int mahogany = 310;

            // if (wood == "P")
            if (wood.Equals("P"))
            {
                Console.WriteLine("It will cost you $" + pine);
            }
            else if (wood.Equals("O"))
            {
                Console.WriteLine("It will cost you $" + oak);
            }
            else if (wood.Equals("M"))
            {
                Console.WriteLine("It will cost you $" + mahogany);
            }
            else
            {
                Console.WriteLine("$" + 0);
            }

        }
    }
}

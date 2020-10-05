using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pyramid
{
    //Elijah
    class Program
    {
        static void Main(string[] args)
        {
            //calls it 10 times for each pyramid
            for (int n = 1; n < 11; n++)
            {
                Console.WriteLine(PramidCount(n));
            }
            Console.ReadLine();
        }

        //the recurisve function
        static int PramidCount(int n)
        {
            //base case
            if (n == 1)
            {
                //Main Return
                return n;
            }
            else
            {
                //recursively runs the function until you're down to 1
                return n + PramidCount(n - 1);
            }
        }

    }
}
using System;

namespace FibanacciSequenceronacci_Sequence
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("FibanacciSequenceronacci nbers");

            //for how many you want to count up to
            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine(FibanacciSequencer(n));
            }
        }

        static int FibanacciSequencer(int n)
        {
            //base cases
            //return 0 for 0 and 1 for 1 
            if (n == 0) { return 0; }
            else if (n == 1) { return 1; }
            //else runs the sequence
            else return FibanacciSequencer(n - 1) + FibanacciSequencer(n - 2);
        }
    }
}

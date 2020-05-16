using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate random number generator using 100 as seed.
            var rand = new Random(100);

            // Instantiate random number.
            var rand2 = new Random();

            // Generate and display 1 random integer.
            Console.Write("{0,15:N0}", rand.Next());
            Console.WriteLine();

            // Generate and display 1 random double.
            Console.Write("{0,8:N3}", rand.NextDouble());
            Console.WriteLine();

            // Generate and display 5 random integers.
            Console.WriteLine("Five random integer values:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", rand2.Next());
            Console.WriteLine();

            // Generate and display 5 random floating point values from 0 to 5.
            Console.WriteLine("Five Doubles between 0 and 5.");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N3}", rand2.NextDouble() * 5);

            // Generate and display 5 random integers between 0 and 100.
            Console.WriteLine("Five random integers between 0 and 100:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N0}", rand.Next(101));
            Console.WriteLine();

            // Generate and display 5 random floating point values from 0 to 50.
            Console.WriteLine("Five Doubles between 0 and 5.");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N3}", rand.NextDouble() * 50);
        }
    }
}

using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            num++; //( -- )and( ++ )adds or subtracts 1 from the variable number. 

            Console.WriteLine( 342 ); // Can print out numbers.
            Console.WriteLine(5 + 8); // Can perfrom basic math operations.
            Console.WriteLine(5 % 2); // Mod operator which does a division and returns the remainder. 
            Console.WriteLine((4 + 2) * 2); // Can use parenthases to perform order of operation.
            Console.WriteLine(5 / 2); // Any math operation done with integers stay as integers
            Console.WriteLine(5.1 / 2.3); // When using decimals it converts your output to a decimal also
            Console.WriteLine(5 / 3.5); // Even when used with an integer. 
            Console.WriteLine(num); // Writes the integer stored as the num variable after num++ operator has excecuted.
            Console.WriteLine(Math.Abs(-40)); // Returns the absolute value of a 32-bit signed integer. 
            Console.WriteLine(Math.Sqrt(64)); // Returns the square root of a specified number. 
            


            Console.ReadLine();

        }
    }
}

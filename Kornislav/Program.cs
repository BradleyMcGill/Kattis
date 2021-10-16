using System;

namespace Kornislav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter four posative intergers seperated by spaces: ");
            int[] lengths = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            Array.Sort(lengths);

            Console.Write("The largest rectangle you can make with these is " + (lengths[0] * lengths[2]).ToString());

        }
    }
}

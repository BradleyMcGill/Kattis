/*
https://open.kattis.com/problems/aaah
*/

using System;

namespace Aaah_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the \"aaah\" youre willing to do today (0-999 'a's followed by a single 'h')");
            string acceptable = Console.ReadLine();

            Console.WriteLine("Please enter the length of the \"aaah\" the doctor is asking for (0-999 'a's followed by a single 'h')");
            string required = Console.ReadLine();

            if (acceptable.Length >= required.Length){
                Console.WriteLine("go");
            }
            else {
                Console.WriteLine("no");
            }
        }
    }
}

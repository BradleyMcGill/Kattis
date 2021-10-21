/*
https://open.kattis.com/problems/echoechoecho
*/

using System;

namespace Echo_Echo_Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to Echo: ");
            string word = Console.ReadLine() + " ";

            Console.WriteLine(word + word + word);
        }
    }
}

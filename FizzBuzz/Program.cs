using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";

            Console.Write("Please enter the divisor you would like to replace with \"Fizz\": ");
            int fizz = int.Parse(Console.ReadLine());

            Console.Write("Please enter the divisor you would like to replace with \"Buzz\": ");
            int buzz = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number you would like to run until: ");
            int count = int.Parse(Console.ReadLine());

            for (int x = 1; x <= count; x += 1){
                output = "";
               if (x % fizz == 0){
                   output += "Fizz";
               }
               if (x % buzz == 0){
                   output += "Buzz";
               }
               if (!(x % fizz == 0) && !(x % buzz == 0)) {
                   output = x.ToString();
               }
                Console.WriteLine(output);
            }
        }
    }
}

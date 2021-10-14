using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of megabites available each month (0<X<100): ");
            int perMonth = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of months passed (0<N<100): ");
            int monthsPassed = int.Parse(Console.ReadLine());

            int[] used = new int[monthsPassed];

            for (int x = 0;x<monthsPassed;x+=1){
                Console.Write("Please enter the number GB used in month " + (1+x).ToString() + ": ");
                used[x] = int.Parse(Console.ReadLine());
            }

            while ((perMonth * monthsPassed) <= (used[0] + used[1] + used[2])){
            
                for (int x = 0;x<monthsPassed;x+=1){
                    Console.Write("Please enter the number GB used in month " + (1+x).ToString() + ": ");
                    used[x] = int.Parse(Console.ReadLine());
                }
            }
            
            int nextMonth = (perMonth * monthsPassed) - (used[0] + used[1] + used[2]) + perMonth;

            Console.WriteLine(nextMonth);
        }
    }
}

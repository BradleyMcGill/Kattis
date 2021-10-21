/*
https://open.kattis.com/problems/freefood
*/

using System;

namespace FreeFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, totalDays;
            string[] dates;
            int[] year = new int[365];

            totalDays = 0;

            Console.Write("Please enter the number of events this year: ");
            int numberOfEvents = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfEvents; i += 1){
                Console.WriteLine("Please enter the start day and the end day of event " + i.ToString() +" seperated by a space: ");
                dates = Console.ReadLine().Split(" ");
                start = int.Parse(dates[0]);
                end = int.Parse(dates[1]);
                for (int z = start -1; z <= end -1; z += 1){
                    year[z] = 1;
                }
            }
            foreach (int v in year){
                if (v == 1){
                    totalDays += 1;
                }
            }
            Console.WriteLine(totalDays.ToString() + " this year are taken up by an event!");
        }
    }
}

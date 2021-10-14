using System;

namespace Trik
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] cups = new int[3] {1,0,0};
            int[] Swapper(int to, int from){

                int temp = cups[to];
                cups[to] = cups[from];
                cups[from] = temp;

                return cups;
            }



            Console.WriteLine(@"You will be asked to enter your moves. 
Enter 'A' if you want to swap cup 1 and 2.
Enter 'B' if you want to swap cup 2 and 3.
Enter 'C' if you want to swap cup 1 and 3.
You can enter up to 50 moves in one line.
The ball starts in the leftmost cup (1)");
            Console.Write("Please enter your moves: ");
            string moves = Console.ReadLine();

           foreach (char v in moves) {
                if (v == 'A'){
                    Swapper(1,0);
                }
                else if (v == 'B'){
                    Swapper(2,1);
                }
                else if (v == 'C'){
                    Swapper(0,2);
                }
            }
            Console.WriteLine(string.Join(" ", cups));
        }
    }
}

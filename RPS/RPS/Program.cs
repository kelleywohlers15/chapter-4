using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ai = rnd.Next(1, 3);
            int userEntry;

            Console.WriteLine("Welcome to Rock Paper Scissors ");
            Console.WriteLine("I am your game show host Tron Tricker");
            Console.WriteLine("Enter the following numbers to play: " + 
                "\n1 - rock \n2 - scissors \n3 - paper");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (ai == 1)
            {
                if (userEntry ==1)
                {
                    Console.WriteLine("You Tied");
                }
                else if (userEntry == 2)
                {
                    Console.WriteLine("You Lost");
                }
                else
                {
                    Console.WriteLine("You Won!!");
                }
            }
            else if (ai == 2)
            {
                if (userEntry == 1)
                {
                    Console.WriteLine("You won");
                }
                else if (userEntry == 2)
                {
                    Console.WriteLine("You Tied");
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }
            else if (ai == 3)
            {
                if (userEntry == 1)
                {
                    Console.WriteLine("You lost ");
                }
                else if (userEntry == 2)
                {
                    Console.WriteLine("You won");
                }
                else
                {
                    Console.WriteLine("You tied");
                }
            }
            
         
        }
    }
}

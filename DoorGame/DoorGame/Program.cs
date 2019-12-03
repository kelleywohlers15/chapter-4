using System;

namespace DoorGame
{
    class Program
    {

        static void Main(string[] args)
        {
      
            int rndNumber = rnd.Next(1, 2, 3); //chose a door between 1 and 3
            int userEntry;
            string choice;
            Console.WriteLine("Pick a door 1, 2, or 3 ");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 1)
            {
                Console.WriteLine("Congratulations You get a cookie" );
            

            }
        }
    }
}

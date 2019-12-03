using System;

namespace CheckMonth2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;

            Console.WriteLine("Enter a birth day and month.");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry >= 1 && userEntry <= 12 )
            {
                Console.WriteLine("Your birthday is valid");
            }
            else if (userEntry > 12)
            {
                Console.WriteLine("your birthday is invalid");
            }






        }
    }
}

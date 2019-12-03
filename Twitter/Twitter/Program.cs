using System;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            Console.WriteLine("please enter your message");
            entry = Console.ReadLine();

            if (entry.Length <=140)
            {
                Console.WriteLine("The length of your message is acceptable");
            }
            else
            {
                Console.WriteLine("message to long");
            }











            
        }
    }
}

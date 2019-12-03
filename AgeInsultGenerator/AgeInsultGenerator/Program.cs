using System;

namespace AgeInsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterAge;
            string result = null;
        
            Console.WriteLine("Please enter an age so i can make fun of you ");
            Console.WriteLine("If you call me a boomer you might die of old age");
            enterAge = Convert.ToInt32(Console.ReadLine());

            if (enterAge <=12)
            {
                result = "You are just a young punk.";
            }
            else if (enterAge > 12 && enterAge <= 17)
            {
                result = "Your generation is the problem";
            }
            else if (enterAge > 17 && enterAge <= 25)
            {
                result = "Get a job and pay some taxes hippie!";
            }
            else if (enterAge > 25 && enterAge <= 35)
            {
                result = "Pay attention to your kids ";
            }
            else if (enterAge > 35 && enterAge <= 45)
            {
                result = "Stop saying you're getting old";
            }
            else if (enterAge > 45 && enterAge <= 54)
            {
                result = "No you can't retire yet";
            }
            else if (enterAge > 54 && enterAge <= 62)
            {
                result = "retire your too old";
            }
            else if (enterAge > 62)
            {
                result = "Get a job you do nothing";
            }


            Console.WriteLine(result);
        }


    }
}

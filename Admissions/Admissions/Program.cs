using System;

namespace Admissions
{
    class Program
    {
        static void Main(string[] args)
        {

            double userEntryGpa;
            int userEntryTestScore;

            Console.WriteLine("what is your GPA?");
            userEntryGpa = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("what is your Test Score?");
            userEntryTestScore = Convert.ToInt32(Console.ReadLine());




            if (userEntryGpa > 3.0 && userEntryTestScore > 60)
            {
                Console.WriteLine("Accepted to school");
            }
            else if (userEntryGpa < 3.0 && userEntryTestScore > 80)
            {
                Console.WriteLine("Accepted into school");
            }
            else
            {
                Console.WriteLine("You are rejected");
            }





      
        }
    }
}

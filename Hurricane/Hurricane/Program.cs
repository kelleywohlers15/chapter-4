using System;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntryWindSpeed;
            string result = null;
            Console.WriteLine("What is the wind speed of the hurricane");
            userEntryWindSpeed = Convert.ToInt32(Console.ReadLine());

            if (userEntryWindSpeed >= 157)
            {
                Console.WriteLine("Category 5 Hurricane");
            }
            else if (userEntryWindSpeed < 157 && userEntryWindSpeed >= 130) 
            {
                Console.WriteLine("Catergory 4 Hurricane");
            }
            else if (userEntryWindSpeed < 130 && userEntryWindSpeed >= 111)
            { 
                Console.WriteLine("Category 3 Hurricane");
            }
            else if (userEntryWindSpeed < 111 && userEntryWindSpeed >=96)
            {
                Console.WriteLine("category 2 Hurricane");
            }
            else if (userEntryWindSpeed <96 && userEntryWindSpeed >= 74)
            {
                Console.WriteLine("Category 1 Hurricane");
            }
            else if (userEntryWindSpeed < 74)
            {
                Console.WriteLine("It is not a hurricane");
            }

            Console.WriteLine(result);
        }

    }
}

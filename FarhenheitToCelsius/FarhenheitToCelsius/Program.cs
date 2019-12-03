using System;

namespace FarhenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            int temp8AM;
            int temp12PM;
            int temp5PM;
            int temp8AMtoCelsius;
            int temp12PMtoCelsius;
            int temp5PMtoCelsius;


            Console.WriteLine("Please enter the temperature at 8:00 am");
             temp8AM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the temperature at 12:00 pm");
            temp12PM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the temperature at 5:00 pm");
            temp5PM= Convert.ToInt32(Console.ReadLine());

            if (temp8AM <32 && temp12PM < 32 && temp5PM <32)
            {
                Console.WriteLine("It is freezing");
            }
            else if (temp8AM > 100 && temp12PM > 100 && temp5PM > 100)
            {
                Console.WriteLine("It is hot outside");
            }

            temp8AMtoCelsius = (temp8AM- 32) / (9 / 5);
            temp12PMtoCelsius = (temp12PM - 32) / (9 / 5);
            temp5PMtoCelsius = (temp5PM - 32) / (9 / 5);

            Console.WriteLine("8:00 AM - " + temp8AMtoCelsius);
            Console.WriteLine("12:00 PM - " +temp12PMtoCelsius);
            Console.WriteLine("5:00 PM - " +temp5PMtoCelsius);
        }
    }
}

using System;

namespace checkCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterCredit;
            string result = null;

            Console.WriteLine("Please enter a purchase price of an item");
            enterCredit = Convert.ToInt32(Console.ReadLine());
             if (enterCredit >=5000)
            {
                result = "Error your purchase is to big.";
            }
            else if (enterCredit <=5000)
            {
                result = "Your purchase has been comfirmed!";
            }

            Console.WriteLine(result);

        }
    }
}

using System;

namespace DayThreeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of diners"  );
            string amountOfDiners = Console.ReadLine();

            Console.WriteLine("Please enter the cost each person paid");
            string amountPerDiner = Console.ReadLine();

            int numberOfDiners = Convert.ToInt32(amountOfDiners);
            int costPerDiners = Convert.ToInt32(amountPerDiner);
            int totalCostOfBill = numberOfDiners * costPerDiners;

            if(totalCostOfBill >50)
            {   
                Console.WriteLine("The cost of the bill is {0}", totalCostOfBill);
                Console.WriteLine("Receive a 10% discount");
                Console.WriteLine("Your new bill is {0} ", totalCostOfBill * .9);
            }

            if(totalCostOfBill <50)
            {
                Console.WriteLine("The cost of the bill is {0}", totalCostOfBill);
                Console.WriteLine("Receive a 5% discount");
                Console.WriteLine("Your new bill is {0} ", totalCostOfBill * .95);

            }


            Console.ReadKey();
            
        }
    }
}

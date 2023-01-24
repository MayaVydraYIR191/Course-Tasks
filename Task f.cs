using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minFishNum = 2;
            const int minRiceNum = 500;
            const double minSaltSugar = 35;
            const int minNori = 8;
            const string goToShopMessage = "Go to Shop please!";
            Console.WriteLine($"Minimum number of fish:{minFishNum}");
            Console.WriteLine("Enter the number of fish");
            int fishNum = Convert.ToInt32(Console.ReadLine());
            if(fishNum < minFishNum)
            {
                Console.WriteLine(goToShopMessage);
                return;
            }
            else if(fishNum > 100)
            {
                Console.WriteLine("For what do you need so many fish dude?");
                return;

            }
            else
            {
                Console.WriteLine("Slice them!");
            }
            Console.WriteLine("Enter the number of Rice:");
            int riceNum = Convert.ToInt32(Console.ReadLine());
            if (riceNum < minRiceNum)
            {
                Console.WriteLine(goToShopMessage);
                return;

            }
            else
            {
                Console.WriteLine("Add it to fish");
            }
            Console.WriteLine("Enter the number of sugar and salt:");
            double sugarSaltNum = Convert.ToDouble(Console.ReadLine());
            if (sugarSaltNum >= minSaltSugar)
            {
                Console.WriteLine("Add it to fish and rice");
            }
            else
            {
                Console.WriteLine(goToShopMessage);
                return;
            }
            Console.WriteLine("Time for Nori Seaweed!");
            double noriCount = 0;
            while(noriCount < minNori)
            {
                Console.WriteLine("Wrap fish and rice in seaweed leaf");
                noriCount += 2;
            }
            Console.WriteLine("Make it!");
        }
    }
}

using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
            TaskTwo();
            TaskThree();
            TaskFour();
        }

        private static void TaskOne()
        {
            Console.WriteLine("Напишите значения двух катетов");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                double squaregip = a*a + b*b;
                double gip = Math.Sqrt(squaregip);
                Console.WriteLine("Гипотенуза равна: "+gip);
            }
            else
            {
                Console.WriteLine("Не хочу с этим работать");
            }
        }

        private static void TaskTwo()
        {
            Console.WriteLine("Напишите числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a>0 && a<10 && b>0 && b<10)
            {
                int c = a * b;
                Console.WriteLine("Умножение чисел равно: "+ c);
            }
            else
            {
                Console.WriteLine("Неправильные числа");
                return;
            }
        }

        private static void TaskThree()
        {
            Console.WriteLine("Назовите размер таблицы:");
            uint size = Convert.ToUInt32(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.WriteLine(i * j + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void TaskFour()
        {
            Console.WriteLine("Сумма вклада:");
            decimal wklad = Convert.ToDecimal(Console.ReadLine());
            decimal wkladpercent;
            int months = Convert.ToInt32(Console.ReadLine());
            if (months < 0)
            {
                Console.WriteLine("Неправильное число");
            }
            for (int i = 0; i < months; i++)
            {
                wkladpercent = wklad / 100 * 7;
                wklad = wklad + wkladpercent;
            }
        }
    }
}

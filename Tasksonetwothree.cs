using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
            TaskTwo();
            TaskThree();
        }

        private static void TaskOne()
        {
            int num = 0;

            do
            {
                num = num - 20;
                Console.WriteLine(num);
            }
            while (num > -100);
        }

        private static void TaskTwo()
        {
            for (int i = 10; i<=100;i+=5)
            {
                Console.Write(i+" ");
            }
        }
        private static void TaskThree()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a>0 && b>0)
            {
            int sum = 0;
            int count = 0;
            for(int i = a; i<=b;++i)
            {
                sum += i;
                count +=1;
            }
            double sred = sum /count;
            Console.WriteLine(sum);
            Console.WriteLine(sred);
            }
            else
            {
                Console.WriteLine("Wrong numbers");
            }
        }
    }
}

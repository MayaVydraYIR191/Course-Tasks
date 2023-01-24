using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано расстояние в сантиметрах, найдите длину в метрах");
            int rasstoanie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В одном метре 100 сантиметров, значит делим расстояние на 100");
            double rassmetres = rasstoanie / 100;
            double rametr = Math.Round(rassmetres);
            Console.WriteLine(rametr);
            Console.WriteLine("Значит в этом расстоянии полных метров: "+rametr);
        }
    }
}

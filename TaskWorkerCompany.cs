using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Ivanovy = new Company();
            Rabotnik Ivanov = new Rabotnik();
            Ivanovy.Name = "Ivanovy";
            Ivanov.Working = 5;
            Ivanov.BreakRules = 1;
            //Rabotnik.Pay Ivanovpay = 1500; доработаю зарплату!
            Ivanov.Ascendence(Ivanov.Working);
            Ivanov.Banning(Ivanov.BreakRules);
            Ivanovy.Firing();
            Ivanovy.Payment();
        }
    }

    class Rabotnik
    {
        public double Working;
        public static string Status;
        public static bool Ban;
        public int BreakRules;
        public static double Pay;
        public void Ascendence(double Working)
        {
            if (Working >= 5)
            {
                Status = "Senior";
                if(Status == "Senior")
                {
                    Console.WriteLine(Status);
                    Console.WriteLine("Congrats!");
                }
            }
            else if (Working<5 && Working>=3)
            {
                Status = "Middle";
                if(Status =="Middle")
                {
                    Console.WriteLine(Status);
                    Console.WriteLine("More to come!");
                }
            }
        }
        public void Banning(int BreakRules)
        {
            if (BreakRules == 1)
            {
                Ban = true;
                Console.WriteLine("Banned");
            }
            else if (BreakRules == 0)
            {
                Console.WriteLine("Nice");
            }
            else
            {
                Console.WriteLine("It can't be true!");
            }
        }
    }
    class Company
    {
        public string Name;
        public void Firing()
        {
            if (Rabotnik.Ban == true)
            {
                Rabotnik.Status = "Fired";
                Console.WriteLine("Fired");
            }
        }
        public void Payment()
        {
            if (Rabotnik.Status == "Senior" )
            {
                Rabotnik.Pay += 1500;
                Console.WriteLine(Rabotnik.Pay);
            }
        }

    }



}



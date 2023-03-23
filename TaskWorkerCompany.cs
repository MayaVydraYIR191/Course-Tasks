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
            Ivanov.Ascendence(Ivanov.Working);
            Ivanov.Banning(Ivanov.BreakRules);
            Company fireIvanov = new Company();
            fireIvanov.Firing(Ivanov);
            Ivanovy.Payment();
        }
    }

    class Rabotnik
    {
        public double Working { get { return Working; } set { if (Working <= 300) { Console.WriteLine("Lower than needed"); } else { Working = value; } } }
        public static string Status { get { return Status; } set { Status = value; } }
        public static bool Ban { get { return Ban; } set { Ban = value; } }
        public int BreakRules { get { return BreakRules; } set { if (BreakRules <= 0) { Console.WriteLine("Impossible"); } else { BreakRules = value; } } }
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
        public string Name { get { return Name; } set { Name = value; } }
        public int Age { get { return Age; } set { if (Age < 0) { Console.WriteLine("Impossible"); } else { Age = value; } } }

        public string DaughterCompanies { get { return DaughterCompanies; } set { DaughterCompanies = value; } }

        public void Firing(Rabotnik rabotnik)
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



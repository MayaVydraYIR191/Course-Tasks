using System;

namespace TaskTech
{
    class Program
    {
        static void Main(string[] args)
        {
            //тут что то будет? пускай будет пока пустое, потом исправлю
        }
    }

    public abstract class Technika
    {
        public string TechName;
        public int Age;
        public void Start()
        {
            TechName = Console.ReadLine();
            if(TechName == "DishWasher")
            {
                Console.WriteLine("DishWasher is turning on");
            }

        }
        public void Summon()
        {
            //мне почему то не дает сделать и абстрактное, и с возвращаемым значением, пока будет так?
        }
    }
    public abstract class DishWasher : Technika
    {
        public bool Working = false;
        public void TurnOn()
        {
            if (Working == false)
            {
                Working = true;
                Console.WriteLine("The machine is turned on!");
            }
            else if (Working == true)
            {
                Working = false;
                Console.WriteLine("The machine is turned off");
            }
        }
    }

    public abstract class WashingMachine : Technika
    {
        public bool Working = false;
        public void TurnOn()
        {
            if (Working == false)
            {
                Working = true;
                Console.WriteLine("The machine is turned on!");
            }
            else if (Working == true)
            {
                Working = false;
                Console.WriteLine("The machine is turned off");
            }
        }
    }



}

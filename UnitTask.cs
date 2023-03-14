using System;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    abstract class Units
    {
        string unitName;
        int unitNumber;
        string[] unitAbilities;

        public bool MoveRight;
        public bool MoveLeft;
        public bool Jump;
        public bool Stopping;
        void Move()
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "Right":
                    MoveRight = true;
                    Console.WriteLine("Character is moving right");
                    break;
                case "Left":
                    MoveLeft = true;
                    Console.WriteLine("Character is moving left");
                    break;
                case "Jump":
                    Jump = true;
                    Console.WriteLine("Character is jumping");
                    break;
                case "Stop":
                    Stopping = true;
                    Console.WriteLine("Character stops in place");
                    break;
            }
        }
        public abstract void Stand();
    }
    interface IMagicalAbilities
    {
        static string Fireball(string ability)
        {
            ability = Console.ReadLine();
            if(ability == "Fireball")
            {
                Console.WriteLine("The raging fire essence is thrown into an enemy");
            }
            else if (ability == "Fly")
            {
                ability = IFlight.Flying(ability);
            }
            else if (ability == "Swim")
            {
                ability = ISwim.Swimming(ability);
            }
            return (ability);
        }
    }
    interface IFlight
    {
        static string Flying(string ability)
        {
            ability = Console.ReadLine();
            if (ability == "Fly")
            {
                Console.WriteLine("Character bursts into the air, opening its wings");
            }
            else if (ability == "Swim")
            {
                ability = ISwim.Swimming(ability);
            }
            else if (ability == "Fireball")
            {
                ability = IMagicalAbilities.Fireball(ability);
            }
            return (ability);
        }
    }
    interface ISwim
    {
        static string Swimming(string ability)
        {
            ability = Console.ReadLine();
            if (ability == "Swim")
            {
                Console.WriteLine("Character jumps into the water and swims");
            }
            else if(ability == "Fly")
            {
                ability = IFlight.Flying(ability);
            }
            else if(ability == "Fireball")
            {
                ability = IMagicalAbilities.Fireball(ability);
            }
            return (ability);
        }
    }


}

using System;

namespace ConsoleApp63
{

    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior();
            war.unitName = "King";
            war.unitNumber = 1;

            Dragon dra = new Dragon();
            dra.unitName = "Goldwing";
            dra.unitNumber = 2;

            Gryphon gry = new Gryphon();
            gry.unitName = "Shard";
            gry.unitNumber = 3;
        }
    }

    public class Warrior : Units, IFlight, ISwim,IMagicalAbilities
    {
        public new void Move()
        {
            Console.WriteLine($"{unitName} is Moving");
        }
        public override void Stand()
        {
            Console.WriteLine($"{unitName} stands");
        }
        public void Fireball()
        {
                Console.WriteLine($"{unitName} can't use Fireball");
        }
        public void Swimming()
        {
            Console.WriteLine($"{unitName} swims");
        }
        public void Flying()
        {
            Console.WriteLine($"{unitName} can't fly!");
        }

    }

    public class Dragon: Units, IFlight, ISwim, IMagicalAbilities
    {
        public new void Move()
        {
            Console.WriteLine($"{unitName} is Moving");
        }
        public override void Stand()
        {
            Console.WriteLine($"{unitName} stands");
        }
        public void Fireball()
        {
            Console.WriteLine($"{unitName} throws a Fireball into its enemies");
        }
        public void Swimming()
        {
            Console.WriteLine($"{unitName} swims");
        }
        public void Flying()
        {
            Console.WriteLine($"{unitName} flies!");
        }

    }
    public class Gryphon : Units, IFlight, ISwim, IMagicalAbilities
    {
        public new void Move()
        {
            Console.WriteLine($"{unitName} is Moving");
        }
        public override void Stand()
        {
            Console.WriteLine($"{unitName} stands");
        }
        public void Fireball()
        {
            Console.WriteLine($"{unitName} can't throw a Fireball");
        }
        public void Swimming()
        {
            Console.WriteLine($"{unitName} can't swim");
        }
        public void Flying()
        {
            Console.WriteLine($"{unitName} flies!");
        }

    }
    public abstract class Units
    {
        public string unitName;
        public int unitNumber;

        public bool MoveRight;
        public bool MoveLeft;
        public bool Jump;
        public bool Stopping;
        public void Move()
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
        public void Fireball();
    }
    interface IFlight
    {
        public void Flying();
    }
    interface ISwim
    {
        public void Swimming();
    }


}

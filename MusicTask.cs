using System;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the word");
            string play = Console.ReadLine();
            switch (play)
            {
                case "Guitar":
                    Guitar.Play();
                    break;

                case "Violin":
                    Violin.Play();
                    break;
                case "Piano":
                    Piano.Play();
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }

        }
    }

    interface IPlayable
    {
        public static void Play()
        {
            Console.WriteLine("I play");
        }
    }

    public class Guitar : IPlayable
    {
        public static void Play()
        {
            Console.WriteLine("I am guitar and I am playing");
        }
    }
    public class Violin : IPlayable
    {
        public static void Play()
        {
            Console.WriteLine("I am violin and I am playing");
        }
    }
    public class Piano : IPlayable
    {
        public static void Play()
        {
            Console.WriteLine("I am piano and I am playing");
        }
    }




}

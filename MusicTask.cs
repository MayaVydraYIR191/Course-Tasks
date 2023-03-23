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
                   Guitar playinggui = new Guitar();
                    playinggui.Play();
                    break;
                case "Violin":
                    Violin playingvio = new Violin();
                    playingvio.Play();
                    break;
                case "Piano":
                    Piano playingpia = new Piano();
                    playingpia.Play();
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }

        }
    }

    interface IPlayable
    {
        public void Play();
    }

    public class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("I am guitar and I am playing");
        }
    }
    public class Violin : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("I am violin and I am playing");
        }
    }
    public class Piano : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("I am piano and I am playing");
        }
    }
}

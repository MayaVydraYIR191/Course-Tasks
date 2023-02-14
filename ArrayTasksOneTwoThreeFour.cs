using System;
using System.Collections;

namespace ConsoleApp49
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

        public static void TaskOne()
        {
            int[] arraytwo = new int[6];
            for (int i = 0; i < arraytwo.Length; i++)
            {
                arraytwo[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arraytwo[i]);
            }
            for (int i = 0; i < 6 && i > 3; i++)
            {
                Console.WriteLine("The three last: "+ arraytwo[i]);
            }
            for (int i = arraytwo.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arraytwo[i]);
            }
            for(int i=0;i<arraytwo.Length;i++)
            {
                if (arraytwo[i] % 2 == 0 && arraytwo[i]>5)
                {
                    Console.WriteLine("Bigger than five and multiple of two: "+arraytwo[i]);
                }
            }
            Array.Reverse(arraytwo);
            for(int i = 0; i < arraytwo.Length; i++)
            {
                Console.WriteLine(arraytwo[i]);
            }
        }
        public static int TaskTwo()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
            int maxar = int.MinValue;
            for(int i = 0;i<array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                  
                    if (maxar < array[i, j])
                    {
                        maxar = array[i, j];
                    }
                    
                }
                Console.WriteLine("Max Value = " + maxar);
            }
            return maxar;
        }

        public static void TaskThree()
        {
            string file = Console.ReadLine();
            string[] strochka = file.Split(new char[] {'\\','.','\''});
            for(int i = 0; i < strochka.Length; i++)
            {
                Console.WriteLine(strochka[i]);
                if(i == 6)
                {
                    Console.WriteLine("The file name = "+strochka[i]);
                }
            }
        }
        public static void TaskFour()
        {
            string stroka = Console.ReadLine();
            string[] slova = stroka.Split(new char[] { ' ' });
            int count = 0;
            for(int i =0;i<slova.Length; i++)
            {
                Console.WriteLine(slova[i]);
                count++;
            }
            Console.WriteLine("Words in sentence: "+count);
        }
        
    }
}

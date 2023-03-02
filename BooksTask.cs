using System;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] booksmagazines = new IPrintable[5];
            for (int i = 0; i < booksmagazines.Length; i++)
            {
                Console.WriteLine(booksmagazines[i]);
            }
        }
    }
    interface IPrintable
    {
        void Print()
        {
            Console.WriteLine();
        }
    }
    class Book : IPrintable
    {
        public string bookname;
        public int booknumber;
        static void PrintBooks(IPrintable [] printable)
        {
            Console.WriteLine();
        }
    }
    class Magazine : IPrintable
    {
        public string magname;
        public int magnumber;
        static void PrintMagazines(IPrintable[]printable)
        {
            Console.WriteLine();
        }
    }


}

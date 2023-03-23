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
                if(booksmagazines[i]is Book)
                {
                    PrintBooks(booksmagazines[i]);
                }
                else if(booksmagazines[i] is Magazine)
                {
                    PrintMagazines(booksmagazines[i]);
                }
            }
        }
        static void PrintMagazines(IPrintable printable)
        {
            Console.WriteLine(printable);
        }
        static void PrintBooks(IPrintable printable)
        {
            Console.WriteLine(printable);
        }


    }
    interface IPrintable
    {
        public void Print(IPrintable edition);
    }
    class Book : IPrintable
    {
        public string bookname;
        public int booknumber;
        public void Print(IPrintable book)
        {
            Console.WriteLine("Print Book");
        }
    }
    class Magazine : IPrintable
    {
        public string magname;
        public int magnumber;
        public void Print(IPrintable magazine)
        {
            Console.WriteLine("Print Magazine");
        }
    }


}

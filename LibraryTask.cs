using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
           //окей тут что-нибудь да будет  
        }
    }
    public class Library
    {
        public string BookName;
        public int BookNum;
        public string BookDescription;
        public bool BookGet;
        public void BookIsHere(string bookname)
        {
            if(BookGet == true)
            {
                bookname = BookName;
                Reader.BookGetting(bookname);
            }
        }
    }
    public class Reader
    {
        public static bool BookHere;
        public string readername;
        public delegate void Waiting(string message);
        public static event Waiting WaitOver;
        public static void BookGetting(string reader)
        {
            if (BookHere == true)
            {
                WaitOver?.Invoke("You book is finally here");
            }
        }
    }
}

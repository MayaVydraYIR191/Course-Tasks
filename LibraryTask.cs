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
            Reader tom = new Reader();
            Library library = new Library();
            library.reader.Add(tom);
            tom.Subscribe(Library.Genres.Nonfiction);
            Book biobook = new Book();
            library.book.Add(biobook);
            library.BookAdd += Notification;
            BookAdd(Library.Genres.Nonfiction);
            void Notification(Library.Genres genre)
            {
                if(tom.subscribes[genre])
                {
                    Console.WriteLine("Subscription is done");
                }
            }
        }
    }
    public class Library
    {
        public List<Reader> reader = new List<Reader>();
        public List<Book> book = new List<Book>();
        public delegate void BookAdded(Genres genres);
        public event BookAdded BookAdd;
        public enum Genres
        {
            ScienceFiction,
            RomanticStory,
            Nonfiction

        }
    }
    public class Book
    {
        public string BookName { get; set; }
        public int BookNum { get; set; }
        public bool BookGet;
        public void BookIsHere(string bookname)
        {
            if (BookGet == true)
            {
                bookname = BookName;
                Reader.BookGetting(bookname);
            }
        }
    }

    public class Reader
    {
        public static bool BookHere;
        public string readername { get; set; }
        public delegate void Waiting(string message);
        public static event Waiting WaitOver;
        public static void BookGetting(string reader)
        {
            if (BookHere == true)
            {
                WaitOver?.Invoke("You book is finally here");
            }
        }
        public void Reading(string readerName)
        {
            readername = readerName;
        }
        public Dictionary<Library.Genres, bool> subscribes = new Dictionary<Library.Genres, bool>() {
            { Library.Genres.ScienceFiction, false },
            { Library.Genres.RomanticStory, false },
            { Library.Genres.Nonfiction, false }, };
        public void Subscribe(Library.Genres genre)
        {
            subscribes[genre] = true;
        }
    }
}

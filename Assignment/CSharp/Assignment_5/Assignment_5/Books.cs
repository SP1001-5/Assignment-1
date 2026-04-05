using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine("Book: " + BookName + ", Author: " + AuthorName);
        }
    }

    public class BookShelf
    {
        private Books[] books = new Books[5]; 
        public Books this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                    return books[index];
                else
                    throw new IndexOutOfRangeException("Invalid index for bookshelf");
            }
            set
            {
                if (index >= 0 && index < books.Length)
                    books[index] = value;
                else
                    throw new IndexOutOfRangeException("Invalid index for bookshelf");
            }
        }
    }

    public class BookMain
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();
            for(int i = 0;i < 5; i++){
                Console.Write("Enter the Book name : ");
                string b_name = Console.ReadLine();
                Console.Write("Enter the Author name : ");
                string b_author = Console.ReadLine();
                shelf[i] = new Books(b_name,b_author);
            }
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
        }
    }
}

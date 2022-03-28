namespace program
{
    using System;

    public class Book
    {
        public string NameOfTheBook { get; set; }
        public string BookAuthor { get; set; }

        public Book(string nameOfTheBook, string bookAuthor)
        {
            NameOfTheBook = nameOfTheBook;
            BookAuthor = bookAuthor;
        }

        public override string ToString()
        {
            return BookAuthor + " \"" + NameOfTheBook + "\" ";
        }

    }

    public class BooksList
    {
        List<Book> bookslist;

        public BooksList()
        {
            bookslist = new List<Book>();
        }

        public void Add(string nameOfTheBook, string bookAuthor)
        {
            bookslist.Add(new Book(nameOfTheBook, bookAuthor));
        }

        public Book this[int index]
        {
            get
            {
                return bookslist[index];
            }
            set
            {
                bookslist[index] = value;
            }
        }
    }
}

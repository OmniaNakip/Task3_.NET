namespace Task3
{
    public class Book
    {
        public string title;
        public string author;
        public string ISBN;
        public bool isAvailable;

        public Book(string title, string author, string ISBN, bool isAvailable = true) 
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.isAvailable = isAvailable;
        }
    }

    public class Library
    {
        List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book SearchBook(string title, string author) 
        {
            Book book = null;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title || books[i].author == author) 
                {
                    book = books[i];
                    break;
                }
            }

            return book;
        }

        public string BorrowBook(string title, string author)
        {
            Book book = SearchBook(title, author); 

            if (book == null)                      
                return "Book not found.";

            if (book.isAvailable == false)
                return $"Sorry, '{book.title}' is already borrowed.";

            book.isAvailable = false;              
            return $"You have successfully borrowed '{book.title}' by {book.author}.";
        }

        public string ReturnBook(string title, string author) 
        {
            Book book = SearchBook(title, author);

            if (book == null)
                return "Book not found.";

            if (book.isAvailable == true)
                return $"'{book.title}' was not borrowed.";

            book.isAvailable = true;               
            return $"'{book.title}' has been returned successfully.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("Book A", "Ali", "123"));
            library.AddBook(new Book("Book B", "Mona", "456"));

            Console.WriteLine(library.BorrowBook("Book A", "Ali"));
            Console.WriteLine(library.ReturnBook("Book A", "Ali"));
            Console.WriteLine(library.BorrowBook("Book B", "Mona"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04BooksApp
{
    public class BookManager
    {
        Dictionary<string, Book> books = new Dictionary<string, Book>();

        public void AddBook(Book book)
        {
            books[book.Isbn] = book;
        }

        public BookManager()
        {
            AddBook(new Book()
            {
                Title = "The Accursed God",
                Author = "Vivek Dutta Mishra",
                Price = 399,
                Rating = 4.6,
                Cover = "https://images-na.ssl-images-amazon.com/images/I/41xektjU1NL._SX320_BO1,204,203,200_.jpg",
                Description = "Long before the epic battle, long before even the birth of Kurukshetra, a man swore on his father’s pyre to avenge against the mightiest empire, any civilization had ever seen. Between his might and near-certain destruction of the Empire, stood a warrior, who rose like a phoenix from the ashes of his seven dead brothers — taking the mantle of a fabled Accursed God.",
                Isbn = "‎9387818942"
            });

            AddBook(new Book()
            {
                Title = "Rashmrirathi",
                Author = "Ramdhari Singh Dinkar",
                Price = 199,
                Rating = 4.8,
                Cover = "https://images-na.ssl-images-amazon.com/images/I/51CJYPPo4QL._SX321_BO1,204,203,200_.jpg",
                Description = "Epic poetic tale of Karna of Mahabharata",
                Isbn = "‎‎8180313638"
            });

            AddBook(new Book()
            {
                Title = "The Count of Monte Cristo",
                Author = "Alexandre Dumas",
                Price = 599,
                Rating = 4.8,
                Cover = "https://m.media-amazon.com/images/I/413igIz8MPL._SY346_.jpg",
                Description = "One of the all time greatest classic novel in English and French",
                Isbn = "‎0140449264"
            });

            AddBook(new Book()
            {
                Title = "Kane and Abel",
                Author = "Jeffrey Archer",
                Price = 499,
                Rating = 4.3,
                Cover = "https://images-eu.ssl-images-amazon.com/images/I/51Io01xRjsL._SY264_BO1,204,203,200_QL40_FMwebp_.jpg",
                Description = "A chronological story from the the bright to ultimate conflict of two protaganist",
                Isbn = "‎‎9781509808694"
            });

            AddBook(new Book()
            {
                Title = "The Brethren",
                Author = "John Grisham",
                Price = 250,
                Rating = 4.1,
                Cover = "https://images-eu.ssl-images-amazon.com/images/I/51qDvQN0lsL._SY264_BO1,204,203,200_QL40_FMwebp_.jpg",
                Description = "The story of three convicted judges and Presidential election",
                Isbn = "‎0099280256"
            });
        }

        public List<string> GetIsbns()
        {
            return books.Keys.ToList();
        }

        public Book GetBookByIsbn(string isbn)
        {
            return books[isbn];
        }
    
    
    
    }
}

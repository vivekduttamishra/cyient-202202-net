using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04BooksApp
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public double Rating { get; set; }

        public string Cover { get; set; }

        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04BooksApp
{
    [Serializable]
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public double Rating { get; set; } = 5;

        public string Cover { get; set; }

        public string Description { get; set; }
    }
}

using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book GetBookById(int Id)
        {
            return DataSource().Where(x => x.ID == Id).FirstOrDefault();
        }

        public List<Book> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<Book> DataSource()
        {
            return new List<Book>
            {
                new Book{ID = 1, Title = "React", Author= "Hamad"},
                new Book{ID = 2, Title = "C#", Author= "Imran"},
                new Book{ID = 3, Title = "Java", Author= "Usman"},
                new Book{ID = 4, Title = "Python", Author= "Hamza"},
            };
        }
    }
}

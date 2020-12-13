using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository;

        public BookController()
        {
            bookRepository = new BookRepository();
        }

        public List<Book> GetAllBooks()
        {
            return bookRepository.GetAllBooks();
        }

        public Book GetBook(int id)
        {
            return bookRepository.GetBookById(id);
        }

        public List<Book> SearchBooks(string bookName, string authorName)
        {
            return bookRepository.SearchBook(bookName,authorName);
        }
    }
}

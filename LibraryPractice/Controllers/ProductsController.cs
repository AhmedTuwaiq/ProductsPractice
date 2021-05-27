using System.Collections.Generic;
using System.Linq;
using LibraryPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryPractice.Controllers
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            ViewBag.books = new List<Book>
            {
                new() {Id = 1, Name = "Book1", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 499.99},
                new() {Id = 2, Name = "Book2", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 999.99},
                new() {Id = 3, Name = "Book3", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 399.99},
                new() {Id = 4, Name = "Book4", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 9999.99},
                new() {Id = 5, Name = "Book5", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 799.99}
            };
            
            return View();
        }
        
        // GET
        public IActionResult Details(int id, string color = "green")
        {
            List<string> colors = new()
            {
                "red",
                "green",
                "blue"
            };

            if (!colors.Contains(color))
                color = "green";
            
            List<Book> books = new List<Book>
            {
                new() {Id = 1, Name = "Book1", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 499.99},
                new() {Id = 2, Name = "Book2", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 999.99},
                new() {Id = 3, Name = "Book3", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 399.99},
                new() {Id = 4, Name = "Book4", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 9999.99},
                new() {Id = 5, Name = "Book5", URL = "https://edit.org/images/cat/book-covers-big-2019101610.jpg", Price = 799.99}
            };

            ViewBag.book = books.Find(book => book.Id == id);
            ViewBag.color = color;
            
            return View();
        }
    }
}
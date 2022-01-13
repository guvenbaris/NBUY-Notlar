using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;

namespace BookStoreApp.Controllers
{
    [Route("[controller]s")] // controller'ın ismi ve sonuna s takısı ile gelecek.
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>
        {
            new Book
            {
                Id = 1,
                GenreId = 1, //Personal Growth
                Title = "Lean Startup",
                PageCount = 200,
                PublishDate = new DateTime(2001,06,12)
            },
            new Book
            {
                Id = 2,
                GenreId = 2, // Science Finction
                Title = "Herland",
                PageCount = 250,
                PublishDate = new DateTime(2010,06,23)
            },
            new Book
            {
                Id = 3,
                GenreId = 2, // Science Finction
                Title = "Dune",
                PageCount = 540,
                PublishDate = new DateTime(2001,12,21)
            }
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList();
            return bookList;
        }

        [HttpGet("{id}")] //Root dan almak için
        public Book GetById(int id)
        {
            var book = BookList.Where(b => b.Id == id).SingleOrDefault();
            return book;
        }

        //[HttpGet] // Query ile id ye göre çekme.
        //public Book GetBookById([FromQuery] string id)
        //{
        //    var book = BookList.Where(b => b.Id ==Convert.ToInt32(id)).SingleOrDefault();
        //    return book;
        //}

        //Post
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = BookList.SingleOrDefault(b => b.Title == newBook.Title);
            if (book is not null)
            {
                return BadRequest();
            }

            BookList.Add(newBook);
            return Ok();
        }
        //Put
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id,[FromBody] Book updatedBook)
        {
            var book = BookList.SingleOrDefault(x => x.Id == id);
            if (book is null)
            {
                return BadRequest();
            }

            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            book.Title = updatedBook.Title ?? book.Title;
            return Ok();

        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = BookList.SingleOrDefault(b => b.Id == id);
            if (book is null)
            {
                return BadRequest();
            }

            BookList.Remove(book);
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using AutoMapper;
using BookStoreApp.Application.BookOperations.DeleteBooks;
using BookStoreApp.Application.BookOperations.GetBooks;
using BookStoreApp.DbOperations;
using FluentValidation;
using BookStoreApp.Application.BookOperations.CreateBooks;
using BookStoreApp.Application.BookOperations.UpdateBooks;

namespace BookStoreApp.Controllers
{
    [Route("[controller]s")] // controller'ın ismi ve sonuna s takısı ile gelecek.
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public BookController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBookQuery getBooksQuery = new GetBookQuery(_context, _mapper);
            var result = getBooksQuery.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")] //Root dan almak için
        public IActionResult GetById(int id)
        {
            GetBookByIdQuery getBookByIdQuery = new GetBookByIdQuery(_context, _mapper);

            getBookByIdQuery.BookId = id;
            GetBookByIdQueryValidator validator = new GetBookByIdQueryValidator();
            validator.ValidateAndThrow(getBookByIdQuery);
            var result = getBookByIdQuery.Handle();
            return Ok(result);

        }

        //[HttpGet] // Query ile id ye göre çekme.
        //public Book GetBookById([FromQuery] string id)
        //{
        //    var book = BookList.Where(b => b.Id ==Convert.ToInt32(id)).SingleOrDefault();
        //    return book;
        //}

        //Post
        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand createBooksCommand = new CreateBookCommand(_context, _mapper);
            //validationResult FluentValidationdan geliyor.
            //ValidationResult result =  validator.Validate(createBooksCommand);
            createBooksCommand.Model = newBook;
            CreateBookCommandValidator validator = new CreateBookCommandValidator();

            validator.ValidateAndThrow(createBooksCommand); // Validate and throw et
            createBooksCommand.Handle();
            return Ok();
            //if (!result.IsValid)
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        Console.WriteLine("Özellik " + item.PropertyName + " - Error Message" + item.ErrorMessage);
            //        Console.WriteLine("Hata Kodu : " + item.ErrorCode);
            //    }
            //} 
        }

        //Put
        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody] UpdateBookModel updatedBook, int id)
        {
            UpdateBookCommand updateBookCommand = new UpdateBookCommand(_context);

            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            updateBookCommand.Model = updatedBook;
            updateBookCommand.BookId = id;

            validator.ValidateAndThrow(updateBookCommand);
            updateBookCommand.Handle();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            DeleteBookCommand deleteBookCommand = new DeleteBookCommand(_context);

            deleteBookCommand.BookId = id;
            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            validator.ValidateAndThrow(deleteBookCommand);
            deleteBookCommand.Handle();

            return Ok();
        }
    }
}

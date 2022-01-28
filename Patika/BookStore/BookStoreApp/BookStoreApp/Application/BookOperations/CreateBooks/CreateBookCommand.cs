using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.DbOperations;
using BookStoreApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Application.BookOperations.CreateBooks
{
    public class CreateBookCommand
    {
        public CreateBookModel Model { get; set; }

        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public CreateBookCommand(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Title == Model.Title);
            if (book is not null)
            {
                throw new InvalidOperationException("Book has been already exist.");
            }


            book = _mapper.Map<Book>(Model); //Model ile gelen nesneyi book objesine convert et.
            // new Book();
            //book.Title = Model.Title;
            //book.GenreId = Model.GenreId;
            //book.PageCount = Model.PageCount;
            //book.PublishDate = Model.PublishDate;

            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }

    public class CreateBookModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public int GenreId { get; set; }
        public DateTime PublishDate { get; set; }
    }
}

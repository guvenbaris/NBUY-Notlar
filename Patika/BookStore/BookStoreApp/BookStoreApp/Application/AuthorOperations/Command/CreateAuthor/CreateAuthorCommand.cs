using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.DbOperations;
using BookStoreApp.Entities;
using Microsoft.AspNetCore.Mvc.Razor;

namespace BookStoreApp.Application.AuthorOperations.Command.CreateAuthor
{
    public class CreateAuthorCommand
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateAuthorModel Model { get; set; }
        public CreateAuthorCommand(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var author =  _context.Authors.SingleOrDefault(x => x.AuthorName == Model.AuthorName);

            if (author is not null)
            {
                throw new InvalidOperationException("This author has been created before.");
            }

            if (_context.Books.SingleOrDefault(x => x.BookId == Model.BookId) is null)
            {
                throw new InvalidOperationException("Book didn't find so Author didn't create");
            }
            author = _mapper.Map<Author>(Model);
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }

    public class CreateAuthorModel
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime Birthdate { get; set; }
        public int BookId { get; set; }
    }
}

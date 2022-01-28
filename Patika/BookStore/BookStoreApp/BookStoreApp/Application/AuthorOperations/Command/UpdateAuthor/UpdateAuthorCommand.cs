using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.DbOperations;

namespace BookStoreApp.Application.AuthorOperations.Command.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        private readonly BookStoreDbContext _context;

        public UpdateAuthorModel Model { get; set; }
        public int AuthorId { get; set; }
        public UpdateAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Author didn't find");
            }

            if (_context.Books.SingleOrDefault(x => x.BookId == Model.BookId) is null)
            {
                throw new InvalidOperationException("Book didn't find so Author didn't create");
            }
            author.AuthorName = string.IsNullOrEmpty(Model.AuthorName) != default ? Model.AuthorName : author.AuthorName;
            author.AuthorSurname = string.IsNullOrEmpty(Model.AuthorSurname) != default ? Model.AuthorSurname : author.AuthorSurname;
            author.BookId = Model.BookId != default ? Model.BookId : author.BookId;
            _context.SaveChanges();
        }
    }

    public class UpdateAuthorModel
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int BookId { get; set; }
    }
}

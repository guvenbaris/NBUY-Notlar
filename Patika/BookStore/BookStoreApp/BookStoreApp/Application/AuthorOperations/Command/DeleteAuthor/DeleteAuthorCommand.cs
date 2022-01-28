using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.DbOperations;

namespace BookStoreApp.Application.AuthorOperations.Command.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        private readonly BookStoreDbContext _context;
        public int AuthorId { get; set; }

        public DeleteAuthorCommand(BookStoreDbContext context)
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

            if (author.BookId == 0)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
            else
            { 
                throw new InvalidOperationException("Author didn't delete because has a book");
            }
        }
    }
}

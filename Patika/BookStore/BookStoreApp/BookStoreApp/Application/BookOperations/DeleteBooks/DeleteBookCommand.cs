using System;
using System.Linq;
using BookStoreApp.DbOperations;

namespace BookStoreApp.Application.BookOperations.DeleteBooks
{
    public class DeleteBookCommand
    {
        private readonly BookStoreDbContext _context;

        public DeleteBookCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public int BookId { get; set; }

        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(b => b.BookId == BookId);
            if (book is null)
            {
                throw new InvalidOperationException("Book didn't find");
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}

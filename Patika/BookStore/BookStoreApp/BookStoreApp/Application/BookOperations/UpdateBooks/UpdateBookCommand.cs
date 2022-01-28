using System;
using System.Linq;
using BookStoreApp.DbOperations;

namespace BookStoreApp.Application.BookOperations.UpdateBooks
{
    public class UpdateBookCommand
    {
        private readonly BookStoreDbContext _context;

        public UpdateBookModel Model { get; set; }
        public int BookId { get; set; }


        public UpdateBookCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.BookId == BookId);
            if (book is null)
            {
                throw new InvalidOperationException("Book didn't find.");
            }
            book.Title = Model.Title ?? book.Title;
            book.GenreId = Model.GenreId != default ? Model.GenreId : book.GenreId;
            _context.SaveChanges();
        }
    }
    public class UpdateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
    }
}

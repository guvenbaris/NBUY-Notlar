using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.DbOperations;
using Newtonsoft.Json.Bson;

namespace BookStoreApp.Application.GenreOperations.Command.DeleteGenre
{
    public class DeleteGenreCommand
    {
        public int GenreId { get; set; }

        private readonly BookStoreDbContext _context;

        public DeleteGenreCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Id == GenreId);

            if (genre is null)
            {
                throw new InvalidOperationException("Genre has already been deleted.");
            }
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.DbOperations;
using BookStoreApp.Entities;

namespace BookStoreApp.Application.GenreOperations.Command.CreateGenre
{
    public class CreateGenreCommand
    {
        private readonly BookStoreDbContext _context;

        public CreateGenreModel Model { get; set; }

        public CreateGenreCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Name == Model.Name);
            if (genre is not null)
            {
                throw new InvalidOperationException("Genre is already exist");
            }
            genre = new Genre();
            genre.Name = Model.Name;

            _context.Genres.Add(genre);
            _context.SaveChanges();
        }
    }
    public class CreateGenreModel
    {
        public string Name { get; set; }
    }


}

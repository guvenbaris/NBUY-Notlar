using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.DbOperations;

namespace BookStoreApp.Application.GenreOperations.Queries.GetGenres
{
    public class GetGenresQuery
    {
        public readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetGenresQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GenreViewModel> Handle()
        {
            var genres = _context.Genres.Where(x => x.IsActive).OrderBy(x => x.Id);
            List<GenreViewModel> returnObj = _mapper.Map<List<GenreViewModel>>(genres);

            return returnObj;

        }

        public class GenreViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
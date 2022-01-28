using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.DbOperations;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public int AuthorId { get; set; }
        public GetAuthorDetailQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public AuthorQueryDetailModel Handle()
        {
            var author = _context.Authors.Include(x => x.Book).SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
            {
                throw new InvalidOperationException("Author didn't find in system");
            }

            return _mapper.Map<AuthorQueryDetailModel>(author);
        }
    }
    public class AuthorQueryDetailModel
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime BirdthDate { get; set; }
        public string Book { get; set; }
    }
}

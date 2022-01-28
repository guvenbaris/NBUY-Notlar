using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.DbOperations;
using BookStoreApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Application.AuthorOperations.Queries.GetAuthors
{
    public class GetAuthorQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public GetAuthorQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<AuthorQueryModel> Handle()
        {
            var authorList = _context.Authors.Include(x => x.Book).OrderBy(z => z.Id).ToList();

            List<AuthorQueryModel> queryModels = _mapper.Map<List<AuthorQueryModel>>(authorList);

            return queryModels;
        }
    }

    public class AuthorQueryModel
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Book { get; set; }
    }
}


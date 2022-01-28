using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BookStoreApp.DbOperations;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Application.BookOperations.GetBooks
{
    public class GetBookQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetBookQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<BookViewModel> Handle()
        {
            var bookList = _context.Books.Include(x=>x.Genre).OrderBy(x => x.BookId).ToList();

            List<BookViewModel> vm = _mapper.Map<List<BookViewModel>>(bookList);
            
            //new List<BookViewModel>();
            //foreach (var book in bookList)
            //{
            //    vm.Add(new BookViewModel
            //    {
            //        Title = book.Title,
            //        Genre = ((GenreEnum)book.GenreId).ToString(),
            //        PublishDate = book.PublishDate.Date.ToString("d"),
            //        PageCount = book.PageCount
            //    });
            //}

            return vm;
        }
    }
    public class BookViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string PublishDate { get; set; }
    }
}

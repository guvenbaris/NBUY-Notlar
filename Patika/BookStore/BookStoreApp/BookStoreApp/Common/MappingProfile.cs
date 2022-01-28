using AutoMapper;
using BookStoreApp.Application.AuthorOperations.Command.CreateAuthor;
using BookStoreApp.Application.AuthorOperations.Queries.GetAuthorDetail;
using BookStoreApp.Application.AuthorOperations.Queries.GetAuthors;
using BookStoreApp.Application.BookOperations.CreateBooks;
using BookStoreApp.Application.BookOperations.GetBooks;
using BookStoreApp.Application.GenreOperations.Queries.GetGenreDetail;
using BookStoreApp.Application.GenreOperations.Queries.GetGenres;
using BookStoreApp.Entities;

namespace BookStoreApp.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookViewModel>().ForMember(dest => dest.Genre,
                opt => opt.MapFrom(src =>src.Genre.Name));
            
            CreateMap<Genre, GetGenresQuery.GenreViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();

            CreateMap<CreateAuthorModel, Author>();
            CreateMap<Author, AuthorQueryModel>().ForMember(dest => dest.Book,
                opt => opt.MapFrom(src => src.Book.Title));

            CreateMap<Author, AuthorQueryDetailModel>().ForMember(dest => dest.Book,
                opt => opt.MapFrom(src => src.Book.Title));

        }
    }
}

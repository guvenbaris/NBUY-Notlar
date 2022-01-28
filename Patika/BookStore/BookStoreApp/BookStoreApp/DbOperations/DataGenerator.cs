using System;
using System.Linq;
using BookStoreApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookStoreApp.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Authors.AddRange(
                new Author
                {
                    AuthorName = "Cemal",
                    AuthorSurname = "Süreya",
                    BookId = 1,
                    Birthdate = new DateTime(1931, 01, 10),
                },
                new Author
                {
                    AuthorName = "Yaşar",
                    AuthorSurname = "Kemal",
                    BookId = 2,
                    Birthdate = new DateTime(1923, 10, 6),
                },
                new Author
                {
                    AuthorName = "Cahit Sıtkı",
                    AuthorSurname = "Tarancı",
                    BookId = 3,
                    Birthdate = new DateTime(1910, 10, 2),
                }
                );
                context.Genres.AddRange(
                    
                    new Genre
                    {
                        Name = "Poetry Book",
                    },
                    new Genre
                    {
                        Name = "Science Fiction",
                    },
                    new Genre
                    {
                        Name = "Romance",
                    }
                    
                 );
                context.Books.AddRange(
                    new Book
                    {
                        //Id = 1,
                        Title = "Göçebe",
                        GenreId = 1,
                        PageCount = 48,
                        PublishDate = new DateTime(1965, 06, 12)
                    },
                    new Book
                    {
                        //Id = 2,
                        Title = "İnce Memed",
                        GenreId = 3,
                        PageCount = 436,
                        PublishDate = new DateTime(1955, 05, 24)
                    },
                    new Book
                    {
                        //Id = 3,
                        Title = "Yaş 35",
                        GenreId = 1,
                        PageCount = 281,
                        PublishDate = new DateTime(1946, 12, 21)
                    }
                );

                context.SaveChanges();
            }

        }
    }
}

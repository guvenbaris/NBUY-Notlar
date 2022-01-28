using AutoMapper;
using BookStoreApp.Application.GenreOperations.Command.CreateGenre;
using BookStoreApp.Application.GenreOperations.Command.DeleteGenre;
using BookStoreApp.Application.GenreOperations.Command.UpdateGenre;
using BookStoreApp.Application.GenreOperations.Queries.GetGenreDetail;
using BookStoreApp.Application.GenreOperations.Queries.GetGenres;
using BookStoreApp.DbOperations;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class GenreController :ControllerBase
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GenreController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetGenres()
        {
            GetGenresQuery query = new GetGenresQuery(_context,_mapper);
            return Ok(query.Handle());
        }

        [HttpGet("{id}")]
        public IActionResult GetGnreDetail(int id)
        {
            GetGenreDetailQuery query = new GetGenreDetailQuery(_context,_mapper);

            query.GenreId = id;
            GetGenreDetailQueryValidator validator = new GetGenreDetailQueryValidator();
            validator.ValidateAndThrow(query);
            return Ok(query.Handle());
        }

        [HttpPost]
        public IActionResult AddGenre([FromBody] CreateGenreModel newGenre)
        {
            CreateGenreCommand command = new CreateGenreCommand(_context);
            command.Model = newGenre;
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult AddGenre(int id,[FromBody] UpdateGenreModel updateGenre)
        {
            UpdateGenreCommand command = new UpdateGenreCommand(_context);
            command.GenreId = id;
            command.Model = updateGenre;

            UpdateGenreCommandValidator validator = new UpdateGenreCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGenre(int id)
        {
            DeleteGenreCommand command = new DeleteGenreCommand(_context);
            command.GenreId = id;

            DeleteGenreCommandValidator validator = new DeleteGenreCommandValidator();

            command.Handle();
            return Ok(); 
        }
    }
}

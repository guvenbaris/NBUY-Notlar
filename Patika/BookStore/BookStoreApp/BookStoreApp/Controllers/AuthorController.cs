using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using BookStoreApp.Application.AuthorOperations.Command.CreateAuthor;
using BookStoreApp.Application.AuthorOperations.Command.DeleteAuthor;
using BookStoreApp.Application.AuthorOperations.Command.UpdateAuthor;
using BookStoreApp.Application.AuthorOperations.Queries.GetAuthorDetail;
using BookStoreApp.Application.AuthorOperations.Queries.GetAuthors;
using BookStoreApp.DbOperations;
using FluentValidation;

namespace BookStoreApp.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;

        public AuthorController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            GetAuthorQuery query = new GetAuthorQuery(_context, _mapper);
            var authors = query.Handle();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            GetAuthorDetailQuery query = new GetAuthorDetailQuery(_context, _mapper);
            GetAuthorDetailQueryValidator validator = new GetAuthorDetailQueryValidator();
            query.AuthorId = id;

            validator.ValidateAndThrow(query);

            return Ok(query.Handle());
        }

        [HttpPost]
        public IActionResult AddAuthor([FromBody] CreateAuthorModel model)
        {
            CreateAuthorCommand command = new CreateAuthorCommand(_context, _mapper);

            command.Model = model;
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();

            validator.ValidateAndThrow(command);
            command.Handle();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor([FromBody] UpdateAuthorModel model, int id)
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);

            command.AuthorId = id;
            command.Model = model;

            UpdateAuthorCommandValidator validator = new UpdateAuthorCommandValidator();

            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteResult(int id)
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);

            command.AuthorId = id;

            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();

            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Validators;

namespace BookStoreApp.Application.AuthorOperations.Command.CreateAuthor
{
    public class CreateAuthorCommandValidator :AbstractValidator<CreateAuthorCommand> 
    {

        public CreateAuthorCommandValidator()
        {
            RuleFor(x => x.Model.AuthorName).NotEmpty().MinimumLength(2);
            RuleFor(x => x.Model.AuthorSurname).NotEmpty().MinimumLength(2);
            RuleFor(x => x.Model.Birthdate).NotEmpty();
            RuleFor(x => x.Model.BookId).GreaterThan(0);
        }
    }

}

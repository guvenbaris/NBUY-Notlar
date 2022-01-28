using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace BookStoreApp.Application.AuthorOperations.Command.UpdateAuthor
{
    public class UpdateAuthorCommandValidator :AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorCommandValidator()
        {
            RuleFor(x => x.Model.AuthorName).NotEmpty().MinimumLength(2);
            RuleFor(x => x.Model.AuthorSurname).NotEmpty().MinimumLength(2);
            RuleFor(x => x.Model.BookId).GreaterThan(0);
        }

    }
}

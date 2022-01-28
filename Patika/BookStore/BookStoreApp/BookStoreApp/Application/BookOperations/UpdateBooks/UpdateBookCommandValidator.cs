using FluentValidation;

namespace BookStoreApp.Application.BookOperations.UpdateBooks
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(c => c.Model.GenreId).GreaterThan(0);
            RuleFor(c => c.Model.Title).NotEmpty().MinimumLength(4);
        }
    }
}

using FluentValidation;

namespace BookStoreApp.Application.BookOperations.DeleteBooks
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(c => c.BookId).GreaterThan(0);
        }
    }
}

using FluentValidation;

namespace BookStoreApp.Application.BookOperations.GetBooks
{
    public class GetBookByIdQueryValidator : AbstractValidator<GetBookByIdQuery>
    {
        public GetBookByIdQueryValidator() 
        {
            RuleFor(c => c.BookId).GreaterThan(0);
        }
    }
}

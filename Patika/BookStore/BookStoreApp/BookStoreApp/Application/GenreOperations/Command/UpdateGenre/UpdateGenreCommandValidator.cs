using FluentValidation;

namespace BookStoreApp.Application.GenreOperations.Command.UpdateGenre
{
    public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreCommandValidator()
        {
            RuleFor(x => x.Model.Name).NotEmpty().MinimumLength(4).When(x => x.Model.Name != string.Empty);

        }
       

    }
}

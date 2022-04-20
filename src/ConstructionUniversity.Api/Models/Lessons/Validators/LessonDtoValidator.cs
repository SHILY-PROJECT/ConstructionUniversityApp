using FluentValidation;

namespace ConstructionUniversity.Api.Models.Lessons.Validators;

public class LessonDtoValidator : AbstractValidator<LessonDto>
{
    public LessonDtoValidator()
    {
        RuleFor(x => x.Name).Length(2, 200);
        RuleFor(x => x.Date).NotNull().NotEmpty();
    }
}
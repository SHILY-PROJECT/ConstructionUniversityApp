using FluentValidation;

namespace ConstructionUniversity.Api.Models.JournalOfStudentPerformance.Validators;

public class StudentPerformanceDtoValidator : AbstractValidator<StudentPerformanceDto>
{
    public StudentPerformanceDtoValidator()
    {
        RuleFor(x => x.IsWas).NotNull().NotEmpty();
        RuleFor(x => x.Student).NotNull().NotEmpty();
        RuleFor(x => x.Lesson).NotNull().NotEmpty();
        RuleFor(x => x.Mark).InclusiveBetween(0, 5);
    }
}
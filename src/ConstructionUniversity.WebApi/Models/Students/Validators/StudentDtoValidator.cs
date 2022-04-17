using FluentValidation;

namespace ConstructionUniversity.WebApi.Models.Students.Validators;

public class StudentDtoValidator : AbstractValidator<StudentDto>
{
    public StudentDtoValidator()
    {
        RuleFor(x => x.FirstName).Length(2, 50);
        RuleFor(x => x.LastName).Length(2, 50);
        RuleFor(x => x.Email).Length(2, 170).EmailAddress();
    }
}
using FluentValidation;
using ConstructionUniversity.WebApi.Models.Teachers;

namespace ConstructionUniversity.WebApi.Models.Teachers.Validators;

public class TeacherDtoValidator : AbstractValidator<TeacherDto>
{
    public TeacherDtoValidator()
    {
        RuleFor(x => x.FirstName).Length(2, 50);
        RuleFor(x => x.LastName).Length(2, 50);
        RuleFor(x => x.Email).Length(2, 170).EmailAddress();
    }
}
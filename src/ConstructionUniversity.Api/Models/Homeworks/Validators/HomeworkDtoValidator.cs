using ConstructionUniversity.Api.Models.Homeworks;
using FluentValidation;

namespace ConstructionUniversity.Api.Models.Homeworks.Validators;

public class HomeworkDtoValidator : AbstractValidator<HomeworkDto>
{
    public HomeworkDtoValidator()
    {
        RuleFor(x => x.Name).Length(2, 200);
        RuleFor(x => x.Discription).Length(0, 500);
    }
}
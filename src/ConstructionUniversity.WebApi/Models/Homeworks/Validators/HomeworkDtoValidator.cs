using ConstructionUniversity.WebApi.Models.Homeworks;
using FluentValidation;

namespace ConstructionUniversity.WebApi.Models.Homeworks.Validators;

public class HomeworkDtoValidator : AbstractValidator<HomeworkDto>
{
    public HomeworkDtoValidator()
    {
        RuleFor(x => x.Name).Length(2, 200);
        RuleFor(x => x.Discription).Length(0, 500);
    }
}
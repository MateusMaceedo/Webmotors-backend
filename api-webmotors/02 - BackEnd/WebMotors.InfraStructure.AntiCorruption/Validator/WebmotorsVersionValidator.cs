using FluentValidation;
using WebMotors.InfraStructure.AntiCorruption.WebMotors.Entities;

namespace WebMotors.InfraStructure.AntiCorruption.Validator
{
    public class WebmotorsVersionValidator : AbstractValidator<Versions>
    {
        public WebmotorsVersionValidator()
        {
            RuleFor(x => x.ModelId).Cascade(CascadeMode.Stop)
              .NotNull().WithMessage("O campo ModelId é obrigatório")
              .NotEmpty().WithMessage("O campo ModelId é obrigatório");

            RuleFor(x => x.Id).Cascade(CascadeMode.Stop)
              .NotNull().WithMessage("O campo Id é obrigatório")
              .NotEmpty().WithMessage("O campo Id é obrigatório");

            RuleFor(x => x.Name).Cascade(CascadeMode.Stop)
              .NotNull().WithMessage("O campo Name é obrigatório")
              .NotEmpty().WithMessage("O campo Name é obrigatório");
        }
    }
}

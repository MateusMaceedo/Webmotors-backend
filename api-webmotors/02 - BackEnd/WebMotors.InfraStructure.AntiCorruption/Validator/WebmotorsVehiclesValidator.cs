using FluentValidation;
using WebMotors.InfraStructure.AntiCorruption.WebMotors.Entities;

namespace WebMotors.InfraStructure.AntiCorruption.Validator
{
    public class WebmotorsVehiclesValidator : AbstractValidator<Vehicles>
    {
        public WebmotorsVehiclesValidator()
        {
            RuleFor(x => x.Id).Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("O campo Id é obrigatório")
                .NotEmpty().WithMessage("O campo Id é obrigatório");

            RuleFor(x => x.Make).Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("O campo Make é obrigatório")
                .NotEmpty().WithMessage("O campo Make é obrigatório");

            RuleFor(x => x.Model).Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("O campo Model é obrigatório")
                .NotEmpty().WithMessage("O campo Model é obrigatório");

            RuleFor(x => x.Version).Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("O campo Version é obrigatório")
                .NotEmpty().WithMessage("O campo Version é obrigatório");

            RuleFor(x => x.Image).Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("O campo Image é obrigatório")
                .NotEmpty().WithMessage("O campo Image é obrigatório");

            RuleFor(x => x.Km).Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("O campo Km é obrigatório")
                .NotEmpty().WithMessage("O campo Km é obrigatório");

            RuleFor(x => x.Price).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("O campo Price é obrigatório")
               .NotEmpty().WithMessage("O campo Price é obrigatório");

            RuleFor(x => x.YearModel).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("O campo YearModel é obrigatório")
               .NotEmpty().WithMessage("O campo YearModel é obrigatório");

            RuleFor(x => x.YearFab).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("O campo YearFab é obrigatório")
               .NotEmpty().WithMessage("O campo YearFab é obrigatório");

            RuleFor(x => x.Color).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("O campo Color é obrigatório")
               .NotEmpty().WithMessage("O campo Color é obrigatório");
        }
    }
}

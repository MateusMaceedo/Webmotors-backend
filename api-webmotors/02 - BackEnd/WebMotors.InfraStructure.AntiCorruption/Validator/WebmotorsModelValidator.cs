using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.InfraStructure.AntiCorruption.WebMotors.Entities;

namespace WebMotors.InfraStructure.AntiCorruption.Validator
{
    public class WebmotorsModelValidator : AbstractValidator<Model>
    {
        public WebmotorsModelValidator()
        {
            RuleFor(x => x.MakeId).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("O campo MakeId é obrigatório")
               .NotEmpty().WithMessage("O campo MakeId é obrigatório");

            RuleFor(x => x.Id).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("O campo Id é obrigatório")
               .NotEmpty().WithMessage("O campo Id é obrigatório");

            RuleFor(x => x.Name).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("O campo Name é obrigatório")
               .NotEmpty().WithMessage("O campo Name é obrigatório");
        }
    }
}

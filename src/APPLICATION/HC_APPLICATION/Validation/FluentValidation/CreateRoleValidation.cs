using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class CreateRoleValidation: AbstractValidator<CreateRoleDTO>
    {
        public CreateRoleValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Role name cannot be left blank.").MinimumLength(3).WithMessage("Minimum character :3");
            RuleFor(x => x.AppUsers).Empty();
        }
    }
}

using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class CreateDepartmentValidation: AbstractValidator<CreateDepartmentDTO>
    {
        public CreateDepartmentValidation()
        {
            RuleFor(x => x.DepartmentName).NotEmpty().WithMessage("Deparment name cannot be left blank.").MinimumLength(3).WithMessage("Department name must be at least 3 characters!");
        }
    }
}

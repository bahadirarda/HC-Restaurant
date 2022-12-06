using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class UpdateDepartmentValidation: AbstractValidator<UpdateDepartmentDTO>
    {
        public UpdateDepartmentValidation()
        {
            RuleFor(x => x.DepartmentName).NotEmpty().WithMessage("Department name cannot be left blank.").MinimumLength(3).WithMessage("Department name must be at least 3 characters!");
        }
    }
}

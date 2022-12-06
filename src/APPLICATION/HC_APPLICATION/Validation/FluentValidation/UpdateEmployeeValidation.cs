using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class UpdateEmployeeValidation: AbstractValidator<UpdateEmployeeDTO>
    {
        public UpdateEmployeeValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name cannot be left blank.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name cannot be left blank.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty!");
            RuleFor(x => x.Address).MinimumLength(3).MaximumLength(500).WithMessage("Minimum character: 3, Maximum character: 500");
            RuleFor(x => x.DepartmentId).NotEmpty().WithMessage("Department id cannot be left blank.!");
        }
    }
}

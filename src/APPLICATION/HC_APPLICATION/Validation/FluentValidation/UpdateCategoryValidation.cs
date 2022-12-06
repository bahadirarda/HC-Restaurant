using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class UpdateCategoryValidation: AbstractValidator<UpdateCategoryDTO>
    {
        public UpdateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name cannot be left blank.").MinimumLength(3).MaximumLength(96).WithMessage("Minimum character: 3, Maximum character: 96");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be left blank.").MinimumLength(3).MaximumLength(3000).WithMessage("Minimum character: 3, Maximum character: 3000");
        }
    }
}

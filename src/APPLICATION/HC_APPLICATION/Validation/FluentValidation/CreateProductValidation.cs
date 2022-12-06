using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class CreateProductValidation: AbstractValidator<CreateProductDTO>
    {
        public CreateProductValidation()
        {
            
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Product name cannot be left blank.").MinimumLength(3).MaximumLength(96).WithMessage("Minimum character: 3 , Maximum character: 96");
            
            RuleFor(x => x.Description).MinimumLength(3).MaximumLength(3000).WithMessage("Minimum character: 3 , Maximum character : 3000");
            
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Unit price cannot be left blank.").GreaterThan(0).WithMessage("Unit price must be greater than 0");

            RuleFor(x => x.UnitsInStock).NotEmpty().WithMessage("Units in Stock cannot be left blank.").GreaterThan(Convert.ToInt16(0)).WithMessage("Units in stock must be greater than 0");

            RuleFor(x => x.SubCategoryId).NotEmpty().WithMessage("Sub category id cannot be left blank.");
            RuleFor(x => x.ImagePath).MinimumLength(3).MaximumLength(500).WithMessage("Minimum character :3 , Maximum character: 500").When(x => x.ImagePath != String.Empty);

            RuleFor(x => x.Image).NotEmpty();

        }
    }
}

using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class RegisterValidation: AbstractValidator<RegisterDTO>
    {
        public RegisterValidation()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Full name cannot be left blank.").MinimumLength(3).WithMessage("Full name must be at least 3 characters!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name cannot be left blank.").MinimumLength(3).WithMessage("User name must be at least 3 characters!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail cannot be left blank.").EmailAddress().WithMessage("E-mail address must be in E-mail format!");
            RuleFor(x => x.Address).MinimumLength(3).MaximumLength(500).WithMessage("Minimum character: 3 , Maximum character : 500");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be left blank.").MinimumLength(6).MaximumLength(20).WithMessage("Password must be between a minimum of 6 and a maximum of 20 characters.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm password cannot be left blank.").Equal(x => x.Password).WithMessage("Passwords do not match!");
        }
    }
}

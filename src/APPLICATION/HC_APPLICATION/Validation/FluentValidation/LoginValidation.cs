using FluentValidation;
using HC_APPLICATION.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Validation.FluentValidation
{
    public class LoginValidation: AbstractValidator<LoginDTO>
    {
        public LoginValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("You must enter a username!").MinimumLength(3).WithMessage("Username must be at least 3 characters!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("You must enter a password!").MinimumLength(6).WithMessage("Password must be at least 6 characters!");
        }
    }
}

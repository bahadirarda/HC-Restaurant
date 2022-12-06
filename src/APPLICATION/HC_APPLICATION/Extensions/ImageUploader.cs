using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Extensions
{
    public class ImageUploader: ValidationAttribute
    {
        string extension = "";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;
            if (file != null)
            {
                extension = Path.GetExtension(file.FileName);
                string[] extensions = { "png", "jpg", "jpeg" };
                bool result = extensions.Any(x => extension.EndsWith(x));
                if (!result)
                {
                    return new ValidationResult(GetErrorMessage());
                }
                return ValidationResult.Success;

            }
            return new ValidationResult("Please image select!");
        }

        private string GetErrorMessage()
        {
            return "Valid file types .png , .jpg , .jpeg";
        }

        public string GetExtension()
        {
            return extension;
        }
    }
}

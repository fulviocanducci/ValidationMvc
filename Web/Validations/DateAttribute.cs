using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
namespace Web.Validations
{
   public class DateAttribute : ValidationAttribute, IClientModelValidator
   {
      public void AddValidation(ClientModelValidationContext context)
      {
         context.Attributes.Add("data-val-date-custom", ErrorMessage ?? "Date invalid");
      }

      protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
      {
         if (!DateTime.TryParse(value?.ToString(), out DateTime _))
         {
            return new ValidationResult(ErrorMessage ?? "Date invalid");
         }
         return ValidationResult.Success;
      }
   }
}

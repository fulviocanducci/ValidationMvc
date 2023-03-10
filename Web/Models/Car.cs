using System.ComponentModel.DataAnnotations;
using Web.Validations;
namespace Web.Models
{
   public class Car
   {
      public int Id { get; set; }

      [Required(ErrorMessage = "Digite o nome completo")]
      public string? Name { get; set; }

      [Required(ErrorMessage = "Digite a data de criação")]
      [Date(ErrorMessage = "Data inválida")]
      public DateTime CreatedAt { get; set; }
   }
}

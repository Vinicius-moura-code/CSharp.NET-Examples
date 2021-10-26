using System.ComponentModel.DataAnnotations;

namespace Alura.ListaLeitura.WebApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de senha")]
        [Compare("Password", ErrorMessage = "Senha e confirmação são diferentes.")]
        public string ConfirmPassword { get; set; }
    }
}

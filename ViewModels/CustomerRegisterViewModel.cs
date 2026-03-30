using System.ComponentModel.DataAnnotations;

namespace web_05.ViewModels
{
    public class CustomerRegisterViewModel
    {
        [Required(ErrorMessage = "El nombre completo es obligatorio")]
        [Display(Name = "Nombre Completo")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; } = string.Empty;
    }
}
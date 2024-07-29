using System.ComponentModel.DataAnnotations;

namespace PruebaInssoft.Models
{
    public class Usuario
    {
        [Display(Name = "Identificador")]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string? ApPaterno{ get; set; }
        [Display(Name = "Apellido Materno")]
        public string? ApMaterno { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        
    }
}

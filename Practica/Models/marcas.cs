using System.ComponentModel.DataAnnotations;

namespace Practica.Models
{
    public class marcas
    {
        [Key]
        [Display(Name = "Id")]
        public int id_marcas { get; set; }

        [Display(Name = "Marca")]
        public string? nombre { get; set; }

        [Display(Name = "Estado")]
        public string? estados {  get; set; }
    }
}

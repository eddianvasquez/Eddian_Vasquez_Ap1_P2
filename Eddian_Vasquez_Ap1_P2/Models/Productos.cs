using System.ComponentModel.DataAnnotations;

namespace Eddian_Vasquez_Ap1_p2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El peso debe ser mayor a cero")]
        public double Peso { get; set; }
    }
}


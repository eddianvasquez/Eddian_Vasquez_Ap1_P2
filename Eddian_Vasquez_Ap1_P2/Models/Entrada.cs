
using System.ComponentModel.DataAnnotations;

namespace Eddian_Vasquez_Ap1_p2.Models
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(200)]
        public string Concepto { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El peso debe ser positivo")]
        public double PesoTotal { get; set; }

        [Required]
        public int IdProducido { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "La cantidad debe ser positiva")]
        public double CantidadProducida { get; set; }
    }
}

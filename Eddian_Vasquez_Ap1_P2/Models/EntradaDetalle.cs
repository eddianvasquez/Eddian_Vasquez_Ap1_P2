using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Eddian_Vasquez_Ap1_p2.Models;

namespace Eddian_Vasquez_Ap1_P2.Models
{
    public enum TipoDetalle
    {
        Utilizado = 0,
        Producido = 1
    }

    public class EntradaDetalle
    {
        [Key]
        public int EntradaDetalleId { get; set; }

        [Required(ErrorMessage = "El ID de la Entrada es obligatorio.")]
        public int EntradaId { get; set; }

        [ForeignKey("EntradaId")]
        public virtual Entrada? Entrada { get; set; }

        [Required(ErrorMessage = "El ID del Producto es obligatorio.")]
        public int ProductoId { get; set; }

        [ForeignKey("ProductoId")]
        public virtual Producto? Producto { get; set; }

        [Required(ErrorMessage = "La Cantidad es obligatoria.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "La Cantidad debe ser mayor a cero.")]
        public double Cantidad { get; set; }

        [Required(ErrorMessage = "Debe indicar si el producto fue utilizado o producido.")]
        public TipoDetalle Tipo { get; set; }
    }
}

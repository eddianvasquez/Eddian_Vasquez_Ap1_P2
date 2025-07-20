using Eddian_Vasquez_Ap1_p2.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eddian_Vasquez_Ap1_p2.Models
{
    public class EntradaDetalle
    {
        [Key]
        public int EntradaDetalleId { get; set; }

        public int EntradaId { get; set; }
        [ForeignKey("EntradaId")]
        public Entrada? Entrada { get; set; }

        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto? Producto { get; set; } 

        [Required(ErrorMessage = "La Cantidad es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La Cantidad debe ser al menos 1.")]
        public int Cantidad { get; set; }

        public double PesoEntrada { get; set; }

        [NotMapped]
        public double SubTotalPeso
        {
            get { return Cantidad * (Producto?.Peso ?? 0); }
        }
    }
}
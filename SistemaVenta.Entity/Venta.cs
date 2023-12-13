using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdVenta { get; set; }
        public int? IdUsuario { get; set; }
        public int? TotalProducto { get; set; }
        public decimal? MontoTotal { get; set; }
        public string? Contacto { get; set; }
        public string? Ciudad { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? IdTransaccion { get; set; }
        public DateTime? FechaVenta { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}

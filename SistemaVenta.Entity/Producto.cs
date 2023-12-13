using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class Producto
    {
        public Producto()
        {
            Carritos = new HashSet<Carrito>();
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? IdMarca { get; set; }
        public int? IdSubcategoria { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }
        public string? RutaImagen { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Talle { get; set; }
        public string? Color { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Costo { get; set; }

        public virtual Marca? IdMarcaNavigation { get; set; }
        public virtual Subcategoria? IdSubcategoriaNavigation { get; set; }
        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}

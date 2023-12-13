using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class Usuario
    {
        public Usuario()
        {
            Carritos = new HashSet<Carrito>();
            Venta = new HashSet<Venta>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Clave { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Restablecer { get; set; }

        public virtual TipoUsuario? IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Carrito> Carritos { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}

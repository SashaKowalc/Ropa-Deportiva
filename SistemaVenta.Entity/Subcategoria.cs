using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity
{
    public partial class Subcategoria
    {
        public Subcategoria()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdSubcategoria { get; set; }
        public int? IdCategoria { get; set; }
        public string? Nombre { get; set; }

        public virtual Categoria? IdCategoriaNavigation { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}

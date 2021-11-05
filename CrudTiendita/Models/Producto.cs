using System;
using System.Collections.Generic;

#nullable disable

namespace CrudTiendita.Models
{
    public partial class Producto
    {
        public int Idproductos { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existecia { get; set; }
    }
}

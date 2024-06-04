using System;
using System.Collections.Generic;

namespace Proveedores4.Models
{
    public partial class Proveedore
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cuit { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string DireccionCalle { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public string CodigoPostal { get; set; } = null!;
        public string? SitioWeb { get; set; }
        public string? TipoProductosServicios { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}

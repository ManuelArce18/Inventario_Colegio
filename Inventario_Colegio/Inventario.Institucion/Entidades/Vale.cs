using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Inventario.Institucion.Entidades
{
    public class Vale
    {
        public DateTime FechaSolicitud{ get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaEntregaReal { get; set; }
        public List<Material>
            MatelialesPrestados { get; set; }
        public Profesores Solicitante { get; set; }

       Return 
        public Profesores EncargadoDeAlmacen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicioFT.Models
{
    public class OrdenVenta
    {
        public int Id { get; set; }
        public DateTime FechaEmision { get; set; }
        public int UsuarioId { get; set; }
        public double Total { get; set; }
    }
}
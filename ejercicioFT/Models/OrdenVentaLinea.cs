using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicioFT.Models
{
    public class OrdenVentaLinea
    {

        public int Id { get; set; }
        public int OrdenVentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }


    }
}
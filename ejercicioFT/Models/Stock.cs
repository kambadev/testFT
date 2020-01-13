using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicioFT.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int Existencia { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicioFT.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Double Precio { get; set; }
        public int TipoId { get; set; }        
        public bool Habilitado { get; set; }
        public bool ControlaStock { get; set; }
    }
}
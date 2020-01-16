using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejercicioFT.Models
{
    
    public class Producto
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el precio")]
        [Range(0.01, 99.99,
            ErrorMessage = "Ingrese un valor entre 0.01 y 99.99")]
        public Double Precio { get; set; }
        [DisplayName("Tipo de producto")]
        public virtual int TipoId { get; set; }
        [DisplayName("Esta habilitado?")]
        public bool Habilitado { get; set; }
        [DisplayName("Controla stock?")]
        public bool ControlaStock { get; set; }
    }
}
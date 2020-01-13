using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejercicioFT.Models;

namespace ejercicioFT.Data
{
    public class ProductosRepo
    {
        private static readonly List<Producto> _productos;


        public List<Producto> ObtenerTodos() {

            return _productos;
        }

        static ProductosRepo()
        {

            _productos = new List<Producto>
            {
                new Producto {
                    Id = 1,
                    Nombre = "Llave Estriada Nro 8",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 18.50,
                    TipoId = 1
                },
                new Producto {
                    Id = 2,
                    Nombre = "Llave Estriada Nro 10",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 22.00,
                    TipoId = 1
                },
                new Producto {
                    Id = 3,
                    Nombre = "Destornillador Phillips Mediano",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 50.00,
                    TipoId = 1
                },

            };
        }

            public Producto ObtenerPorId(int productoId)
        {

            return _productos.Where(x => x.Id == productoId).FirstOrDefault();
        }



    } 
}
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


        public void Agregar(Producto producto)
        {
            //Busco el ID mas alto y le sumo uno, para el nuevo ID de producto como una key autoincrementada
            producto.Id = _productos.Max(x => x.Id)+1;
            _productos.Add(producto);
        }

        public Producto ObtenerPorId(int productoId)
        {

            return _productos.Where(x => x.Id == productoId).FirstOrDefault();
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
                    Precio = 20.50,
                    TipoId = 1
                },
                new Producto {
                    Id = 2,
                    Nombre = "Llave Estriada Nro 10",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 22.50,
                    TipoId = 1
                },
                new Producto {
                    Id = 3,
                    Nombre = "Destornillador Phillips Mediano",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 8.00,
                    TipoId = 1
                },
                new Producto {
                    Id = 4,
                    Nombre = "Luz led 50w E27",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 2.00,
                    TipoId = 2
                },
                new Producto {
                    Id = 5,
                    Nombre = "Ficha 3 patas macho",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 3.00,
                    TipoId = 2
                },
                new Producto {
                    Id = 6,
                    Nombre = "Tomacorriente de pared para embutir",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 15.00,
                    TipoId = 2
                },
                new Producto {
                    Id = 7,
                    Nombre = "Pegamento para ceramicos x 1kg",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 5.00,
                    TipoId = 3
                },
                new Producto {
                    Id = 8,
                    Nombre = "Cuchara albañil nro. 2",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 15.00,
                    TipoId = 3
                },
                new Producto {
                    Id = 9,
                    Nombre = "Bolsa cemento x 40kg",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 30.00,
                    TipoId = 3
                },
                new Producto {
                    Id = 10,
                    Nombre = "Manguera reforzada rollo x 50mts",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 65.00,
                    TipoId = 4
                },
                new Producto {
                    Id = 11,
                    Nombre = "Maceta de arcilla 10lts",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 85.00,
                    TipoId = 4
                },
                new Producto {
                    Id = 12,
                    Nombre = "Podadora electrica Gamma",
                    ControlaStock = true,
                    Habilitado = true,
                    Precio = 90.00,
                    TipoId = 4
                },

            };
        }         



    } 
}
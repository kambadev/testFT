using ejercicioFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicioFT.Data
{
    public class OrdenVentaRepo
    {
        private static readonly List<OrdenVenta> _ordenes;
        private static readonly List<OrdenVentaLinea> _ordenesLineas;

        /// <summary>
        /// Crea una nueva orden de venta y devuelve el nro. de ID asignado para
        /// que luego sea utilizado como ID en AgregarProductoLinea()
        /// </summary>
        /// <returns></returns>
        public int AgregarOrdenVenta()
        {            
            int nextId = _ordenes.Max(x => x.Id) + 1;
            _ordenes.Add(new OrdenVenta
            {
                Id = nextId,
                ClienteId = 1,
                FechaEmision = DateTime.Now,
                Total = 0
            });
            return nextId;
        }

        public void AgregarProductoLinea(Producto producto, int cantidad, int ordenVentaId)
        {
            //Averiguar el proximo nro de ID disponible
            int nextId = _ordenesLineas.Max(x => x.Id) + 1;
            _ordenesLineas.Add(new OrdenVentaLinea
            {
                Id = nextId,
                Cantidad = cantidad,
                OrdenVentaId = ordenVentaId,
                Precio = producto.Precio,
                ProductoId = producto.Id
            });
        }

        public List<OrdenVentaLinea> ObtenerLineasPorOrdenVentaId(int ordenVentaId) {

            return _ordenesLineas.Where(x => x.OrdenVentaId == ordenVentaId).ToList();
        }

    }
}
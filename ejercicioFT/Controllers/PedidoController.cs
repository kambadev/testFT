using ejercicioFT.Data;
using ejercicioFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejercicioFT.Controllers
{
    
    public class PedidoController : Controller
    {

        ProductosRepo _productosRepo = new ProductosRepo();
        OrdenVentaRepo _ordenVentaRepo = new OrdenVentaRepo();        
        

        public RedirectToRouteResult AgregarAlPedido(int productoId, int cantidad, int ordenVentaId, string returnUrl)
        {
            Producto producto = _productosRepo.ObtenerPorId(productoId);            
            if (producto != null)
            {
                _ordenVentaRepo.AgregarProductoLinea(_productosRepo.ObtenerPorId(productoId), cantidad, ordenVentaId);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult QuitarDelPedido(int productoId, int cantidad, int ordenVentaId, string returnUrl)
        {
            //Falta logica

            return RedirectToAction("Index", new { returnUrl });
        }

        private OrdenVenta Pedido()
        {
            OrdenVenta ordenVenta = (OrdenVenta)Session["OrdenVenta"];
            if (ordenVenta == null)
            {
                ordenVenta = new OrdenVenta();
                Session["OrdenVenta"] = ordenVenta;
            }
            
            return ordenVenta;
        }
    }
}
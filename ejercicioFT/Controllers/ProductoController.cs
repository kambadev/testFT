using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejercicioFT.Models;
using ejercicioFT.Data;

namespace ejercicioFT.Controllers
{
    public class ProductoController : Controller
    {
        ProductosRepo _productosRepo = new ProductosRepo();
        // GET: Lista
        [Route("Productos/")]
        public ActionResult Listado()
        {
            return View(_productosRepo);

        }

        [Route("Producto/{id}")]
        public ActionResult Detalle(string id)
        {

            return View(_productosRepo.ObtenerPorId(int.Parse(id)));

        }

        /*public void Index() {
            Response.Write("<h1>Aca se mostrará la lista de productos</h1>");
        }*/
    }
}
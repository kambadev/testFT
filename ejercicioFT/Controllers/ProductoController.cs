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
        TiposRepo _tiposRepo = new TiposRepo();
        // GET: Lista
        [Route("Productos/")]
        public ActionResult Listado()
        {
            //Paso el objeto para poder utilizar los metodos ya que los necesito
            //para cada articulo que voy listando
            ViewBag.ListaOpciones = _tiposRepo;
            return View(_productosRepo);

        }

        [Route("Producto/{id}")]
        public ActionResult Detalle(string id)
        {
            ViewBag.ListaOpciones = _tiposRepo.ObtenerTodos();
            return View(_productosRepo.ObtenerPorId(int.Parse(id)));

        }

        [Route("Producto/Nuevo")]
        public ActionResult Nuevo()
        {

            ViewBag.ListaOpciones = _tiposRepo.ObtenerTodos();

            return View();

        }

        [Route("Producto/Nuevo")]
        [HttpPost]
        public ActionResult Nuevo(Producto producto)
        {
            _productosRepo.Agregar(producto);
            return RedirectToAction("Listado");
        }

        /*public void Index() {
            Response.Write("<h1>Aca se mostrará la lista de productos</h1>");
        }*/
    }
}
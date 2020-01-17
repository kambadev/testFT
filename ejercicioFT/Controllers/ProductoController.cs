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
        public int ItemsPorPagina { get; set; }
        // GET: Lista
        [Route("Productos/")]
        [Route("")]
        public ActionResult Listado()
        {
            //Paso el objeto para poder utilizar los metodos ya que los necesito
            //para cada articulo que voy listando

            ViewBag.ListaOpciones = _tiposRepo;
            return View(_productosRepo.ObtenerTodos());


        }

        [Route("Productos/Tipo/{categoria}")]
        public ActionResult Listado(int categoria)
        {
            //Paso el objeto para poder utilizar los metodos ya que los necesito
            //para cada articulo que voy listando

            ViewBag.ListaOpciones = _tiposRepo;
            return View(_productosRepo.ObtenerPorTipoId(categoria));


        }

        [Route("Producto/{id}")]
        public ActionResult Detalle(string id)
        {
            Producto prod = _productosRepo.ObtenerPorId(int.Parse(id));            
            ViewBag.tipo = _tiposRepo.ObtenerPorId(prod.TipoId).Descripcion;

            return View(prod);

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
            ViewBag.ListaOpciones = _tiposRepo;
            return RedirectToAction("Listado");
        }

        /*public void Index() {
            Response.Write("<h1>Aca se mostrará la lista de productos</h1>");
        }*/
    }
}
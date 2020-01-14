using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejercicioFT.Models;
using ejercicioFT.Data;

namespace ejercicioFT.Controllers
{
    public class ListaController : Controller
    {
        Producto _productosRepo = new Producto();
        // GET: Lista
        /* public ActionResult Index()
         {            
             return View();
         }*/

        public void Index() {
            Response.Write("<h1>Aca se mostrará la lista de productos</h1>");
        }
    }
}
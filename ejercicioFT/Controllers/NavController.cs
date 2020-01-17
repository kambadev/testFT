using ejercicioFT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejercicioFT.Controllers
{
    public class NavController : Controller
    {
        TiposRepo _tiposRepo = new TiposRepo();

        public PartialViewResult Menu() {
            //"Menu lateral";

            ViewBag.tipos = _tiposRepo.ObtenerTodos();
            return PartialView();

        }
    }
}
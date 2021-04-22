using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoApendizado.Models.ViewModels;

namespace ProjetoApendizado.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

       [HttpPost]
       public ActionResult Incluir(UsuarioViewModel viewModel)
       {
            return View();
        }

       
    }
}
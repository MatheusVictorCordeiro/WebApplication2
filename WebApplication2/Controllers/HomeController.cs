using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> todasAsNoticias;

        public HomeController()
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderBy(x => x.Data);
            
        }
        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);
            var todasAscategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasAscategorias;
            return View(ultimasNoticias);
        }

        public ActionResult TodasAsNoticias()
        {

            return View(todasAsNoticias);
        }

        public ActionResult MostrarNoticia(int noticiaId, string titulo, string categoria)
        {

            return View(todasAsNoticias.FirstOrDefault(x=> x.NoticiaId == noticiaId));

        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }


    }
}
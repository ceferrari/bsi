using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    public class CategoriasController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Index()
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Produtos = db.Produtos.ToList();

            return View(db.Categorias.ToList());
        }

        public ActionResult Detalhes(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Produtos = db.Produtos.ToList();

            return View(db.Categorias.Find(id));
        }

        public ActionResult Editar(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Produtos = db.Produtos.ToList();

            return View(db.Categorias.Find(id));
        }

        public ActionResult Criar()
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Produtos = db.Produtos.ToList();

            return View(new Categoria());
        }

        public ActionResult Excluir(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            Categoria categoria = db.Categorias.Find(id);
            db.Categorias.Remove(categoria);
            db.SaveChanges();

            return Json(categoria);
        }

        public ActionResult ExcluirModal(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return PartialView("~/Views/Shared/_ModalExcluir.cshtml", db.Categorias.Find(id));
        }

        [HttpPost]
        public ActionResult Salvar(Categoria categoria)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            db.Set<Categoria>().AddOrUpdate(categoria);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
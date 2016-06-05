using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    [Authorize]
    public class CategoriasController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Index()
        {
            ViewBag.Produtos = db.Produtos.ToList();

            return View(db.Categorias.ToList());
        }

        public ActionResult Detalhes(int id)
        {
            ViewBag.Produtos = db.Produtos.ToList();

            return View(db.Categorias.Find(id));
        }

        public ActionResult Editar(int id)
        {
            ViewBag.Produtos = db.Produtos.ToList();

            return View(db.Categorias.Find(id));
        }

        public ActionResult Criar()
        {
            ViewBag.Produtos = db.Produtos.ToList();

            return View(new Categoria());
        }

        public ActionResult Excluir(int id)
        {
            Categoria categoria = db.Categorias.Find(id);
            db.Categorias.Remove(categoria);
            db.SaveChanges();

            return Json(categoria);
        }

        public ActionResult ExcluirModal(int id)
        {
            return PartialView("~/Views/Shared/_ModalExcluir.cshtml", db.Categorias.Find(id));
        }

        [HttpPost]
        public ActionResult Salvar(Categoria categoria)
        {
            db.Set<Categoria>().AddOrUpdate(categoria);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
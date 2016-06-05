using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Index()
        {
            ViewBag.Categorias = db.Categorias.ToList();

            return View(db.Produtos.ToList());
        }

        public ActionResult Detalhes(int id)
        {
            ViewBag.Categorias = db.Categorias.ToList();

            return View(db.Produtos.Find(id));
        }

        public ActionResult Editar(int id)
        {
            ViewBag.Categorias = db.Categorias.ToList();

            return View(db.Produtos.Find(id));
        }

        public ActionResult Criar()
        {
            ViewBag.Categorias = db.Categorias.ToList();

            return View(new Produto());
        }

        public ActionResult Excluir(int id)
        {
            Produto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult ExcluirModal(int id)
        {
            return PartialView("~/Views/Shared/_ModalExcluir.cshtml", db.Produtos.Find(id));
        }

        [HttpPost]
        public ActionResult Salvar(Produto produto)
        {
            produto.AtualizaCampos();
            db.Set<Produto>().AddOrUpdate(produto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Insere(int id)
        {
            Produto produto = db.Produtos.Find(id);
            produto.Insere(1);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult Retira(int id)
        {
            Produto produto = db.Produtos.Find(id);
            produto.Retira(1);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult AumentaMinimo(int id)
        {
            Produto produto = db.Produtos.Find(id);
            produto.SetEstoqueMinimo(produto.EstoqueMinimo + 1);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult DiminuiMinimo(int id)
        {
            Produto produto = db.Produtos.Find(id);
            produto.SetEstoqueMinimo(produto.EstoqueMinimo - 1);
            db.SaveChanges();

            return Json(produto);
        }
    }
}
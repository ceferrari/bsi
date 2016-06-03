using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    public class ProdutosController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Index()
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Categorias = db.Categorias.ToList();

            return View(db.Produtos.ToList());
        }

        public ActionResult Detalhes(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Categorias = db.Categorias.ToList();

            return View(db.Produtos.Find(id));
        }

        public ActionResult Editar(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Categorias = db.Categorias.ToList();

            return View(db.Produtos.Find(id));
        }

        public ActionResult Criar()
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            ViewBag.Categorias = db.Categorias.ToList();

            return View(new Produto());
        }

        public ActionResult Excluir(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            Produto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult ExcluirModal(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return PartialView("~/Views/Shared/_ModalExcluir.cshtml", db.Produtos.Find(id));
        }

        [HttpPost]
        public ActionResult Salvar(Produto produto)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            produto.AtualizaCampos();
            db.Set<Produto>().AddOrUpdate(produto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Insere(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            Produto produto = db.Produtos.Find(id);
            produto.Insere(1);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult Retira(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            Produto produto = db.Produtos.Find(id);
            produto.Retira(1);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult AumentaMinimo(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            Produto produto = db.Produtos.Find(id);
            produto.SetEstoqueMinimo(produto.EstoqueMinimo + 1);
            db.SaveChanges();

            return Json(produto);
        }

        public ActionResult DiminuiMinimo(int id)
        {
            if (Session != null && Session["usuarioLogadoID"] == null)
            {
                return RedirectToAction("Login", "Home");
            }

            Produto produto = db.Produtos.Find(id);
            produto.SetEstoqueMinimo(produto.EstoqueMinimo - 1);
            db.SaveChanges();

            return Json(produto);
        }
    }
}
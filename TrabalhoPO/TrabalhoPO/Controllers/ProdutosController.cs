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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                Salvar(produto);

                ViewBag.Message = "Produto editado com sucesso!";
            }

            ViewBag.Categorias = db.Categorias.ToList();

            return View(produto);
        }

        public ActionResult Criar()
        {
            ViewBag.Categorias = db.Categorias.ToList();
            ViewBag.NextId = db.Produtos.Select(x => x.Id).Max() + 1;

            return View(new Produto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                Salvar(produto);

                return RedirectToAction("Index");
            }

            ViewBag.Categorias = db.Categorias.ToList();
            ViewBag.NextId = db.Produtos.Max(x => x.Id) + 1;

            return View(produto);
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

        public void Salvar(Produto produto)
        {
            produto.AtualizaCampos();
            db.Set<Produto>().AddOrUpdate(produto);
            db.SaveChanges();
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
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private MyContext db = new MyContext();

        public ProdutoController()
        {
            ViewBag.Categorias = db.Categorias.ToList();
        }

        public ActionResult Index()
        {
            return RedirectToAction("Lista");
        }

        public ActionResult Lista()
        {
            return View(db.Produtos.ToList());
        }

        public ActionResult Detalhes(int id)
        {
            return View(db.Produtos.Find(id));
        }

        public ActionResult Editar(int id)
        {
            return View(db.Produtos.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                Salvar(produto);

                ViewBag.Mensagem = "Produto editado com sucesso!";
            }

            return View(produto);
        }

        public ActionResult Criar()
        {
            ViewBag.NextId = db.Produtos.Max(x => x.Id) + 1;

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
            try
            {
                Produto produto = db.Produtos.Find(id);
                produto.Retira(1);
                db.SaveChanges();

                return Json(produto);
            }
            catch (Exception ex)
            {
                return JavaScript("erroModal('" + ex.Message + "');");
            }
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
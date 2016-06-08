using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;
using TrabalhoPO.Shared;

namespace TrabalhoPO.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private MyContext db = new MyContext();
        private Utils utils = new Utils();

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

                //return new HttpStatusCodeResult(HttpStatusCode.OK, "Produto editado com sucesso!");
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
            try
            {
                Produto produto = db.Produtos.Find(id);
                db.Produtos.Remove(produto);
                db.SaveChanges();

                return Json(produto);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        public ActionResult ExcluirModal(int id)
        {
            return PartialView("~/Views/Shared/_ModalExcluir.cshtml", db.Produtos.Find(id));
        }

        private void Salvar(Produto produto)
        {
            produto.AtualizaCampos();
            db.Set<Produto>().AddOrUpdate(produto);
            db.SaveChanges();
        }

        public ActionResult Insere(int id)
        {
            try
            {
                Produto produto = db.Produtos.Find(id);
                produto.Insere(1);
                db.SaveChanges();

                return Json(produto);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
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
                string mensagem = utils.Modal(ex.Message);

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, mensagem);
            }
        }

        public ActionResult AumentaMinimo(int id)
        {
            try
            {
                Produto produto = db.Produtos.Find(id);
                produto.SetEstoqueMinimo(produto.EstoqueMinimo + 1);
                db.SaveChanges();

                return Json(produto);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        public ActionResult DiminuiMinimo(int id)
        {
            try
            {
                Produto produto = db.Produtos.Find(id);
                produto.SetEstoqueMinimo(produto.EstoqueMinimo - 1);
                db.SaveChanges();

                return Json(produto);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
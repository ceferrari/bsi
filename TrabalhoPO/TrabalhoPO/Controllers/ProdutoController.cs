using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;
using TrabalhoPO.Models.Factories;
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

        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View(db.Produtos.Find(id));
        }

        [HttpPost]
        public ActionResult Editar(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Salvar(produto);

                    return Json("Produto editado com sucesso!");
                }

                return View(produto);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
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

            Modal modal = new ModalFactory().criar(TipoModal.Excluir, new Modal()
            {
                Titulo = "Excluir Produto",
                Mensagem = "Tem certeza que deseja excluir o produto <strong>" + produto.Id + " - " + produto.Descricao + "</strong> ?",
                AcaoBotaoSecundario = "exclui('Produto'," + id + ")"
            });

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(Produto produto)
        {
            try
            {
                db.Produtos.Remove(produto);
                db.SaveChanges();

                return Json(produto);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        private void Salvar(Produto produto)
        {
            produto.AtualizaCampos();
            db.Set<Produto>().AddOrUpdate(produto);
            db.SaveChanges();
        }

        [HttpPost]
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

        [HttpPost]
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
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
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

        [HttpPost]
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
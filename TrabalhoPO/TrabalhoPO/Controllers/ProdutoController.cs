using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;
using TrabalhoPO.Models.Factories;

namespace TrabalhoPO.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        #region Propriedades e Construtores

        private MyContext db = new MyContext();

        public ProdutoController()
        {
            ViewBag.Categorias = db.Categorias.ToList();
        }

        #endregion

        #region Métodos GET

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

        public ActionResult Criar()
        {
            ViewBag.NextId = db.Produtos.Max(x => x.Id) + 1;

            return View(new Produto());
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

        #endregion

        #region Métodos POST

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Salvar(produto);

                    return Json("Produto criado com sucesso!");
                }

                ViewBag.NextId = db.Produtos.Max(x => x.Id) + 1;

                return View(produto);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
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

        [HttpPost]
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
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
        [ValidateAntiForgeryToken]
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

        #endregion

        #region Métodos Privados e Protegidos

        private void Salvar(Produto produto)
        {
            produto.AtualizaCampos();
            db.Set<Produto>().AddOrUpdate(produto);
            db.SaveChanges();
        }

        #endregion
    }
}
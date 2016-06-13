using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TrabalhoPO.Models;
using TrabalhoPO.Models.Factories;

namespace TrabalhoPO.Controllers
{
    [Authorize]
    public class ProdutoController : BaseController
    {
        #region Propriedades e Construtores

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

        public ActionResult Get(int id)
        {
            var json = Json(db.Produtos.Find(id), JsonRequestBehavior.AllowGet);

            var x = 1;
            return Json(db.Produtos.Find(id), JsonRequestBehavior.AllowGet);
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
        public ActionResult AumentaAtual(Produto produto)
        {
            try
            {
                produto.AumentaAtual(1);
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
        public ActionResult DiminuiAtual(Produto produto)
        {
            try
            {
                produto.DiminuiAtual(1);

                if (!TryValidateModel(produto))
                {
                    var err = ModelState.Values.SelectMany(x => x.Errors);
                    //throw new Exception();
                }
                
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
        public ActionResult AumentaMinimo(Produto produto)
        {
            try
            {
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
        public ActionResult DiminuiMinimo(Produto produto)
        {
            try
            {
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
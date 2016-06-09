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
    public class CategoriaController : Controller
    {
        #region Propriedades e Construtores

        private MyContext db = new MyContext();

        public CategoriaController()
        {
            ViewBag.Produtos = db.Produtos.ToList();
        }

        #endregion

        #region Métodos GET

        public ActionResult Index()
        {
            return RedirectToAction("Lista");
        }

        public ActionResult Lista()
        {
            return View(db.Categorias.ToList());
        }

        public ActionResult Detalhes(int id)
        {
            return View(db.Categorias.Find(id));
        }

        public ActionResult Editar(int id)
        {
            return View(db.Categorias.Find(id));
        }

        public ActionResult Criar()
        {
            ViewBag.NextId = db.Categorias.Max(x => x.Id) + 1;

            return View(new Categoria());
        }

        public ActionResult Excluir(int id)
        {
            Categoria categoria = db.Categorias.Find(id);

            Modal modal = new ModalFactory().criar(TipoModal.Excluir, new Modal()
            {
                Titulo = "Excluir Categoria",
                Mensagem = "Tem certeza que deseja excluir a categoria <strong>" + categoria.Id + " - " + categoria.Descricao + "</strong> ?",
                AcaoBotaoSecundario = "exclui('Categoria'," + id + ")"
            });

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }

        #endregion

        #region Métodos POST

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Salvar(categoria);

                    return Json("Categoria editada com sucesso!");
                }

                return View(categoria);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Salvar(categoria);

                    return Json("Categoria criada com sucesso!");
                }

                ViewBag.NextId = db.Categorias.Max(x => x.Id) + 1;

                return View(categoria);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(Categoria categoria)
        {
            try
            {
                db.Categorias.Remove(categoria);
                db.SaveChanges();

                return Json(categoria);
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        #endregion

        #region Métodos Privados

        private void Salvar(Categoria categoria)
        {
            categoria.SetDataAlteracao();
            db.Set<Categoria>().AddOrUpdate(categoria);
            db.SaveChanges();
        }

        #endregion
    }
}
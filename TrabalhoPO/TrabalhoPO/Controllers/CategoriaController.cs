using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using TrabalhoPO.Models;
using TrabalhoPO.Models.Factories;

namespace TrabalhoPO.Controllers
{
    [Authorize]
    public class CategoriaController : BaseController
    {
        #region Propriedades e Construtores

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
            var categoria = db.Categorias.Find(id);

            var modal = new ModalFactory().criar(TipoModal.Excluir, new Modal()
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
            if (ModelState.IsValid)
            {
                Salvar(categoria);

                return Json("Categoria editada com sucesso!");
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                Salvar(categoria);

                return Json("Categoria criada com sucesso!");
            }

            ViewBag.NextId = db.Categorias.Max(x => x.Id) + 1;

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExcluirAsync(int id)
        {
            var categoria = await db.Categorias.FindAsync(id);
            if (db.Produtos.Count(x => x.Categoria == categoria.Id) > 0)
            {
                throw new Exception("Não é possível excluir uma categoria que contém produtos.");
            }
            db.Categorias.Remove(categoria);
            await db.SaveChangesAsync();

            return Json(categoria);
        }

        #endregion

        #region Métodos Privados e Protegidos

        private void Salvar(Categoria categoria)
        {
            categoria.SetDataAlteracao();
            db.Set<Categoria>().AddOrUpdate(categoria);
            db.SaveChanges();
        }

        #endregion
    }
}
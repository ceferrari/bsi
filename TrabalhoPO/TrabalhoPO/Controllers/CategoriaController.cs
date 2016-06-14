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

        public ActionResult Get(int id)
        {
            return Json(db.Categorias.Find(id), JsonRequestBehavior.AllowGet);
        }

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
        public async Task<ActionResult> Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                await Salvar(categoria);

                return Json("Categoria editada com sucesso!");
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Criar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                await Salvar(categoria);

                return Json("Categoria criada com sucesso!");
            }

            ViewBag.NextId = db.Categorias.Max(x => x.Id) + 1;

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Excluir(Categoria categoria)
        {
            db.Categorias.Remove(db.Categorias.Find(categoria.Id));
            await db.SaveChangesAsync();

            return Json(categoria);
        }

        #endregion

        #region Métodos Privados e Protegidos

        private async Task Salvar(Categoria categoria)
        {
            categoria.SetDataAlteracao();
            db.Set<Categoria>().AddOrUpdate(categoria);
            await db.SaveChangesAsync();
        }

        #endregion
    }
}
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
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

        public ActionResult Get(int id)
        {
            return Json(db.Produtos.Find(id), JsonRequestBehavior.AllowGet);
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
        public async Task<ActionResult> Editar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                await Salvar(produto);

                return Json("Produto editado com sucesso!");
            }

            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Criar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                await Salvar(produto);

                return Json("Produto criado com sucesso!");
            }

            ViewBag.NextId = db.Produtos.Max(x => x.Id) + 1;

            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Excluir(Produto produto)
        {
            db.Produtos.Remove(db.Produtos.Find(produto.Id));
            await db.SaveChangesAsync();

            return Json(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AumentaAtual(int id)
        {
            var produto = await db.Produtos.FindAsync(id);
            produto.AumentaAtual(1);
            await db.SaveChangesAsync();

            return Json(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DiminuiAtual(int id)
        {
            var produto = await db.Produtos.FindAsync(id);
            produto.DiminuiAtual(1);
            await db.SaveChangesAsync();

            return Json(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AumentaMinimo(int id)
        {
            var produto = await db.Produtos.FindAsync(id);
            produto.AumentaMinimo(1);
            await db.SaveChangesAsync();

            return Json(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DiminuiMinimo(int id)
        {
            var produto = await db.Produtos.FindAsync(id);
            produto.DiminuiMinimo(1);
            await db.SaveChangesAsync();

            return Json(produto);
        }

        #endregion

        #region Métodos Privados e Protegidos

        private async Task Salvar(Produto produto)
        {
            produto.AtualizaCampos();
            db.Set<Produto>().AddOrUpdate(produto);
            await db.SaveChangesAsync();
        }

        #endregion
    }
}
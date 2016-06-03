using System.Linq;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                return RedirectToAction("Index", "Produtos");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario u)
        {
            if (ModelState.IsValid)
            {
                var senha = Usuario.sha256(u.Senha);
                var v = db.Usuarios.Where(x => x.Email.Equals(u.Email) && x.Senha.Equals(senha)).FirstOrDefault();

                if (v != null)
                {
                    Session["usuarioLogadoID"] = v.Id.ToString();
                    Session["nomeUsuarioLogado"] = v.Email.ToString();

                    return RedirectToAction("Index");
                }
            }

            return View(u);
        }

        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Login");
        }
    }
}
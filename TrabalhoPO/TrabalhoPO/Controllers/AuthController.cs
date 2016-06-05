using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private MyContext db = new MyContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var usuario = db.Usuarios.Where(x => x.Email.Equals(model.Email) && x.Senha.Equals(model.Senha)).FirstOrDefault();

            if (usuario != null)
            {
                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.Email, usuario.Email)
                }, "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }

            ModelState.AddModelError("", "E-mail ou senha inválido(s)");

            return View(model);
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Produtos");
            }

            return returnUrl;
        }

        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;
            authManager.SignOut("ApplicationCookie");

            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Usuario usuario)
        {
            if (db.Usuarios.Any(x => x.Email.Equals(usuario.Email)))
            {
                ModelState.AddModelError("", "E-mail já cadastrado no sistema.");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return View("Login");
        }
    }
}
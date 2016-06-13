using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using TrabalhoPO.Models;
using TrabalhoPO.Shared;

namespace TrabalhoPO.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Auth model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var senha = new Utils()._SHA256(model.Senha);
            var usuario = db.Usuarios.Where(x => x.Email.Equals(model.Email) && x.Senha.Equals(senha)).FirstOrDefault();

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
                return Url.Action("Index", "Produto");
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
            if (!ModelState.IsValid)
            {
                return View();
            }

            var jaCadastrado = false;

            if (db.Usuarios.Any(x => x.Nome.Equals(usuario.Nome)))
            {
                ModelState.AddModelError("Nome", "Nome já cadastrado no sistema.");

                jaCadastrado = true;
            }

            if (db.Usuarios.Any(x => x.Email.Equals(usuario.Email)))
            {
                ModelState.AddModelError("Email", "E-mail já cadastrado no sistema.");

                jaCadastrado = true;
            }

            if (jaCadastrado)
            {
                return View();
            }

            usuario.Senha = usuario.ConfirmarSenha = new Utils()._SHA256(usuario.Senha);
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return View("Login");
        }
    }
}
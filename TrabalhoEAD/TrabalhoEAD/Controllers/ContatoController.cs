using Contatos.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Contatos.Controllers
{
    public class ContatoController : JsonController
	{
		private ContatoContext db = new ContatoContext();
		
		public ActionResult GetContatos()
		{
			var json = Json(db.Contatos, JsonRequestBehavior.AllowGet);
			return Json(db.Contatos, JsonRequestBehavior.AllowGet);
		}

		public ActionResult AddContato(Contato contato)
		{
			try
			{
				db.Contatos.Add(contato);
				db.SaveChanges();

				return new HttpStatusCodeResult(HttpStatusCode.Created);
			}
			catch
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
			}
		}

		public ActionResult UpdateContato(Contato contato)
		{
			try
			{
				db.Entry(contato).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();

				return new HttpStatusCodeResult(HttpStatusCode.Accepted);
			}
			catch
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
			}
		}

		public ActionResult DeleteContato(int id)
		{
			var contato = db.Contatos.First(x => x.Id == id);

			try
			{
				db.Contatos.Remove(contato);
				db.SaveChanges();

				return new HttpStatusCodeResult(HttpStatusCode.OK);
			}
			catch
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
			}
		}
	}
}
using PagedList;
using SIGA.DAL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SIGA.MVC.Controllers
{
	[Authorize]
	public class UsinaController : Controller
	{
		#region Attributes/Fields

		private SigaContext db = new SigaContext(); 

		#endregion

		#region Actions

		public ViewResult Index(string sortOrder, string currentFilter, string searchDesc, int? page)
		{
			//Ordem
			ViewBag.CurrentSort = sortOrder;
			ViewBag.CodSortParm = sortOrder == "cod" ? "cod_desc" : "cod";
			ViewBag.DescSortParm = String.IsNullOrEmpty(sortOrder) ? "desc_desc" : "";

			//Filtro
			if (searchDesc != null) page = 1; else searchDesc = currentFilter;
			ViewBag.CurrentFilter = searchDesc;

			//Busca todos os registros
			var usinas = from c in db.Usinas select c;

			//Aplica filtragem
			if (!String.IsNullOrEmpty(searchDesc)) usinas = usinas.Where(c => c.Descricao == searchDesc);

			//Aplica ordenação
			switch (sortOrder)
			{
				case "cod": usinas = usinas.OrderBy(c => c.ID); break;
				case "cod_desc": usinas = usinas.OrderByDescending(c => c.ID); break;
				case "desc_desc": usinas = usinas.OrderByDescending(c => c.Descricao); break;
				default: usinas = usinas.OrderBy(c => c.Descricao); break;
			}

			int pageSize = 10;
			int pageNumber = (page ?? 1);
			return View(usinas.ToPagedList(pageNumber, pageSize));
		}
		public ActionResult CreateEdit(string id)
		{
			var usina = string.IsNullOrEmpty(id) ? new Usina() : db.Usinas.Find(id);
			return View(usina);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CreateEdit(Usina model)
		{
            try
            {
                if (ModelState.IsValid)
                {
                    //Create or Edit???
                    if (db.Usinas.Any(x => x.ID == model.ID))
                        db.Entry(model).State = EntityState.Modified;
                    else
                        db.Usinas.Add(model);

                    //Commit
                    db.SaveChanges();

                    //Msg Success
                    TempData.Add("SUCESSO", "Operação realizada com sucesso.");

                    return RedirectToAction("CreateEdit");
                }
            }
            catch (Exception ex)
            {
                TempData.Add("ERRO", ex.Message);
            }

            return View(model);
		}
		[HttpPost]
		public JsonResult DeleteConfirmed(string[] ids)
		{
            foreach (var id in ids)
            {
                db.Usinas.Remove(db.Usinas.Find(id));
            }

            //Commit
            db.SaveChanges();

            return Json(new { success = true });
		}

		#endregion

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
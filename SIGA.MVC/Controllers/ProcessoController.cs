using PagedList;
using SIGA.DAL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SIGA.MVC.Controllers
{
	[Authorize]
	public class ProcessoController : Controller
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
			var processos = from c in db.Processos select c;

			//Aplica filtragem
			if (!String.IsNullOrEmpty(searchDesc)) processos = processos.Where(c => c.Descricao == searchDesc);

			//Aplica ordenação
			switch (sortOrder)
			{
				case "cod": processos = processos.OrderBy(c => c.ID); break;
				case "cod_desc": processos = processos.OrderByDescending(c => c.ID); break;
				case "desc_desc": processos = processos.OrderByDescending(c => c.Descricao); break;
				default: processos = processos.OrderBy(c => c.Descricao); break;
			}

			int pageSize = 10;
			int pageNumber = (page ?? 1);
			return View(processos.ToPagedList(pageNumber, pageSize));
		}
		public ActionResult CreateEdit(string id)
		{
			var processo = string.IsNullOrEmpty(id) ? new Processo() : db.Processos.Find(id);
			return View(processo);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CreateEdit(Processo model)
		{
            try
            {
                if (ModelState.IsValid)
                {
                    //Create or Edit???
                    if (db.Processos.Any(x => x.ID == model.ID))
                        db.Entry(model).State = EntityState.Modified;
                    else
                        db.Processos.Add(model);

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
                db.Processos.Remove(db.Processos.Find(id));
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
﻿using PagedList;
using SIGA.DAL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SIGA.MVC.Controllers
{
	[Authorize]
	public class DisciplinaController : Controller
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
			var disciplinas = from c in db.Disciplinas select c;

			//Aplica filtragem
			if (!String.IsNullOrEmpty(searchDesc)) disciplinas = disciplinas.Where(c => c.Descricao == searchDesc);

			//Aplica ordenação
			switch (sortOrder)
			{
				case "cod": disciplinas = disciplinas.OrderBy(c => c.ID); break;
				case "cod_desc": disciplinas = disciplinas.OrderByDescending(c => c.ID); break;
				case "desc_desc": disciplinas = disciplinas.OrderByDescending(c => c.Descricao); break;
				default: disciplinas = disciplinas.OrderBy(c => c.Descricao); break;
			}

			int pageSize = 10;
			int pageNumber = (page ?? 1);
			return View(disciplinas.ToPagedList(pageNumber, pageSize));
		}
		public ActionResult CreateEdit(string id)
		{
			var disciplina = string.IsNullOrEmpty(id) ? new Disciplina() : db.Disciplinas.Find(id);
			return View(disciplina);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CreateEdit(Disciplina model)
		{
            try
            {
                if (ModelState.IsValid)
                {
                    //Create or Edit???
                    if (db.Disciplinas.Any(x => x.ID == model.ID))
                        db.Entry(model).State = EntityState.Modified;
                    else
                        db.Disciplinas.Add(model);

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
                db.Disciplinas.Remove(db.Disciplinas.Find(id));
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
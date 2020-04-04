using PagedList;
using SIGA.DAL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SIGA.MVC.Controllers
{
    [Authorize]
    public class LocalInstalacaoController : Controller
    {
        #region Attributes/Fields

        private SigaContext db = new SigaContext();

        #endregion

        #region Actions

        public ViewResult Index(string sortOrder, string currentFilter, string searchTag, int? page)
        {
            //var locais = db.Locais.Include(l => l.Disciplina).Include(l => l.Familia).Include(l => l.Processo).Include(l => l.Site).Include(l => l.Usina);
            //return View(locais.ToList());

            //Ordem
            ViewBag.CurrentSort = sortOrder;
            //ViewBag.TagSortParm = sortOrder == "cod" ? "cod_desc" : "cod";
            //ViewBag.TagPaiSortParm = String.IsNullOrEmpty(sortOrder) ? "desc_desc" : "";
            //ViewBag.FamiliaSortParm = String.IsNullOrEmpty(sortOrder) ? "desc_desc" : "";
            //ViewBag.ProcessoSortParm = String.IsNullOrEmpty(sortOrder) ? "desc_desc" : "";
            //ViewBag.UsinaSortParm = String.IsNullOrEmpty(sortOrder) ? "desc_desc" : "";
            //ViewBag.DisciplinaSortParm = String.IsNullOrEmpty(sortOrder) ? "desc_desc" : "";
            //ViewBag.SiteSortParm = String.IsNullOrEmpty(sortOrder) ? "desc_desc" : "";

            //Filtro
            if (searchTag != null) page = 1; else searchTag = currentFilter;
            ViewBag.CurrentFilter = searchTag;

            //Busca todos os registros
            var locais = db.Locais.Include(l => l.Disciplina).Include(l => l.Familia).Include(l => l.Processo).Include(l => l.Site).Include(l => l.Usina);

            //Aplica filtragem
            if (!String.IsNullOrEmpty(searchTag)) locais = locais.Where(l => l.Tag == searchTag);

            //Aplica ordenação
            switch (sortOrder)
            {
                //case "cod": locais = locais.OrderBy(c => c.ID); break;
                //case "cod_desc": locais = locais.OrderByDescending(c => c.ID); break;
                //case "desc_desc": locais = locais.OrderByDescending(c => c.Descricao); break;
                default: locais = locais.OrderBy(c => c.Tag); break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(locais.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult CreateEdit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var li = db.Locais.Find(id);
            if (li == null)
            {
                li = new LocalInstalacao { Tag = id };
            }

            ViewBag.DisciplinaID = new SelectList(db.Disciplinas.OrderBy(d => d.Descricao), "ID", "Descricao", li.DisciplinaID);
            ViewBag.FamiliaID = new SelectList(db.Familias.OrderBy(f => f.Descricao), "ID", "Descricao", li.FamiliaID);
            ViewBag.ProcessoID = new SelectList(db.Processos.OrderBy(p => p.Descricao), "ID", "Descricao", li.ProcessoID);
            ViewBag.SiteID = new SelectList(db.Sites.OrderBy(s => s.Descricao), "ID", "Descricao", li.SiteID);
            ViewBag.UsinaID = new SelectList(db.Usinas.OrderBy(u => u.Descricao), "ID", "Descricao", li.UsinaID);

            return View(li);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEdit(LocalInstalacao model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //Create or Edit?
            var li = string.IsNullOrEmpty(model.Tag) ? new LocalInstalacao() : db.Locais.Find(model.Tag);

            //Bind
            li = model;

            //Add new register
            db.Locais.Add(li);

            //Commit
            db.SaveChanges();

            return RedirectToAction("CreateEdit", 0);
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
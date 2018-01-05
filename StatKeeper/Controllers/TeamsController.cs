using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using StatKeeper.Models;
using StatKeeper.ViewModels;

namespace StatKeeper.Controllers
{
    public class TeamsController : Controller
    {
        private StatKeeperEntities _db = new StatKeeperEntities();

        // GET: Teams
        public ActionResult Index(IEnumerable<TeamViewModel> teamViewModels = null)
        {
            if (teamViewModels == null)
            {
                List<Team> allTeams = _db.Teams.ToList();
                teamViewModels = allTeams.Select(p => new TeamViewModel(p));
            }
            return View(teamViewModels);
        }

        //// GET: Teams/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Teams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Team team = new Team { Name = collection["TeamName"] };
                _db.Teams.Add(team);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Teams/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Teams/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Teams/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Teams/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}

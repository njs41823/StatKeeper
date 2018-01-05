using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using StatKeeper.Models;
using StatKeeper.ViewModels;

namespace StatKeeper.Controllers
{
    public class PlayersController : Controller
    {
        private readonly StatKeeperEntities _db = new StatKeeperEntities();

        // GET: Players
        public ActionResult Index(IEnumerable<PlayerViewModel> playerViewModels = null)
        {
            if (playerViewModels == null)
            {
                List<Player> allPlayers =  _db.Players.ToList();
                playerViewModels = allPlayers.Select(p => new PlayerViewModel(p));
            }
            return View(playerViewModels);
        }

        // GET: Players/Details/5
        public ActionResult Details(int id)
        {
            Player player = _db.Players.FirstOrDefault(p => p.PlayerId == id);
            if (player == null)
            {
                throw new Exception("Player not found.");
            }
            return View(new PlayerViewModel(player));
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Player player = new Player { Name = collection["PlayerName"] };
                _db.Players.Add(player);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int id)
        {
            Player player = _db.Players.FirstOrDefault(p => p.PlayerId == id);
            if (player == null)
            {
                throw new Exception("Player not found.");
            }
            return View(new PlayerViewModel(player));
        }

        // POST: Players/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Player player = _db.Players.FirstOrDefault(p => p.PlayerId == id);
                if (player == null)
                {
                    throw new Exception("Player not found.");
                }
                player.Name = collection["PlayerName"];
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int id)
        {
            Player player = _db.Players.FirstOrDefault(p => p.PlayerId == id);
            if (player == null)
            {
                throw new Exception("Player not found.");
            }
            return View(new PlayerViewModel(player));
        }

        // POST: Players/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Player player = _db.Players.FirstOrDefault(p => p.PlayerId == id);
                if (player == null)
                {
                    throw new Exception("Player not found.");
                }
                _db.Players.Remove(player);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

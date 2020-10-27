using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectClient.Controllers
{
    public class CPFController : Controller
    {
        
        // GET: CPFController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CPFController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CPFController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CPFController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

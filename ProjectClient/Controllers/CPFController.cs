using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjectClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CPFController : Controller
    {
        [HttpGet("{cpf}")]
        public string VerificarCPF(string cpf)
        {
            return JsonConvert.SerializeObject(new Data.CustomValidationCPFAttribute().IsValid(cpf), Formatting.Indented);
        }

        //// GET: CPFController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: CPFController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: CPFController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CPFController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}

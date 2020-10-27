using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CEPController : ControllerBase
    {
        // GET api/<CEPController>/5
        [HttpGet("{cep}")]
        public string Get(string cep)
        {
            var cepObj = Bussiness.Cep.Search(cep);
            return JsonConvert.SerializeObject(cepObj, Formatting.Indented);
        }
    }
}

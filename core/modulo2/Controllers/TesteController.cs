using System;
using Microsoft.AspNetCore.Mvc;
using modulo2.Models;

namespace modulo2.Controllers
{
    [Route("[controller]/[action]")]
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Saudacao"]= "Olá...";
            ViewData["DataInicio"] = DateTime.Now;
            ViewData["Endereco"] = new Endereco()
            {
                Nome = "jefferson",
                Rua = "a",
                Cidade = "b",
                Estado = "c"
            }; 
            return View();
        }
    }
}
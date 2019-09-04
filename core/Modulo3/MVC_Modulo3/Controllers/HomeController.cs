using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Modulo3.Models;

namespace MVC_Modulo3.Controllers
{
    public class HomeController : Controller
    {
        private IAlunoBLL alunoBll;

        public HomeController(IAlunoBLL _alunoBLL)
        {
            alunoBll = _alunoBLL;
        }

        public IActionResult Index()
        {
            //AlunoBLL _aluno = new AlunoBLL();
            List<Aluno> alunos = alunoBll.GetAlunos().ToList();
            return View("Lista",alunos);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
        //    if (String.IsNullOrEmpty(aluno.Nome))
        //        ModelState.AddModelError("Nome", "O nome não pode ser nulo");
        //    if (String.IsNullOrEmpty(aluno.Sexo))
        //        ModelState.AddModelError("Sexo", "O Sexo não pode ser nulo");
        //    if (String.IsNullOrEmpty(aluno.Email))
        //        ModelState.AddModelError("Email", "O Email não pode ser nulo");
        //    if (String.IsNullOrEmpty(aluno.Nascimento.ToShortDateString()))
        //        ModelState.AddModelError("Data", "A Data de nascimento não pode ser nulo");

            if (!ModelState.IsValid)
            {

                return View();
            }
            else
            {
                //AlunoBLL _aluno = new AlunoBLL();
                alunoBll.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }
           
        }

        public IActionResult Edit(int Id)
        {
            //AlunoBLL _aluno = new AlunoBLL();
            Aluno aluno = alunoBll.GetAlunos().Single(x => x.Id == Id);
            return View(aluno);
        }

        [HttpPost]
        public IActionResult Edit(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            else
            {
                //AlunoBLL _aluno = new AlunoBLL();
                alunoBll.AtualizarAluno(aluno);
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delete(int id)
        {
            Aluno aluno = alunoBll.GetAlunos().Single(a => a.Id == id);
            return View(aluno);
        }
        [HttpPost]
        public IActionResult Delete(Aluno aluno)
        {
            alunoBll.DeletarAluno(aluno.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Aluno aluno = alunoBll.GetAlunos().Single(a => a.Id == id);
            return View(aluno);
        }

        public IActionResult Procurar(string procurarPor, string criterio)
        {
            if (procurarPor == "Email")
            {
                Aluno aluno = alunoBll.GetAlunos().SingleOrDefault(a => a.Email == criterio);
                return View(aluno);
            }
            else
            {
                Aluno aluno = alunoBll.GetAlunos().SingleOrDefault(a => a.Nome == criterio);
                return View(aluno);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

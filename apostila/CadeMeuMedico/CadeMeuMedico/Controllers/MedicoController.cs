using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MedicoController : Controller
    {
        private EntidadesCadeMeuMedicoBDEntities db = new EntidadesCadeMeuMedicoBDEntities();
        // GET: Medico
        public ActionResult Index()
        {
            var medicos = db.Medicos.Include(m => m.Cidade).Include(m => m.Especialidades).ToList();
            return View(medicos);
        }
    }
}
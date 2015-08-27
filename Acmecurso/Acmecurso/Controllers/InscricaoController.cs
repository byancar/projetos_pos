using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Acmecurso.Controllers
{
    public class InscricaoController : Controller
    {
        private Models.ApplicationDbContext db = new Models.ApplicationDbContext();

        // GET: Inscricao
        public ActionResult CadastrarAluno()
        {
            var estudantes = db.Estudante.ToList();
            var cursos = db.Cursos.ToList();

            var selectEstudantes = estudantes.Select(e => new SelectListItem()
            {
                Text = string.Format("{0} {1}", e.Nome, e.Sobrenome),
                Value = e.Id.ToString()
            });

            var selectCursos = cursos.Select(c => new SelectListItem()
            {
                Text = c.Nome,
                Value = c.Nome.ToString()
            });

            ViewBag.CursoId     = selectCursos;
            ViewBag.EstudanteId = selectEstudantes;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarAluno(Models.Inscricao inscricao)
        {

            if (ModelState.IsValid)
            {
                inscricao.DataIncricao = DateTime.Now;
                db.Inscricao.Add(inscricao);
                db.SaveChanges();
                ViewBag.Mensagem = "Aluno cadastrado com sucesso.";
                return View("Sucesso");
            }

            return View(inscricao);
        }
    }
}
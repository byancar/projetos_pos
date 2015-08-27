using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Acmecurso.Models
{
    [Table("Professor")]
    public class Professor
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Display(Name = "Titulação")]
        public string Titulacao { get; set; }

        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; }

    }
}
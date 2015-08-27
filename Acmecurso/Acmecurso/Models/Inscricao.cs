using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Acmecurso.Models
{
    [Table("Inscricao")]
    public class Inscricao
    {
        public int Id { get; set; }

        [Display(Name = "Curso")]
        public int CursoId { get; set; }

        [Display(Name = "Estudante")]
        public int EstudanteId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Inscrição")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataIncricao { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Estudante estudante { get; set; }
    }
}
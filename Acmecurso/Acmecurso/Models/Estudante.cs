using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Acmecurso.Models
{
    public class Estudante
    {
        public int Id { get; set; }

        [Display(Name = "Primeiro Nome")]
        [StringLength(50,MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Último Nome")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Sobrenome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Matrícula")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DataMatricula { get; set; }
    }
}
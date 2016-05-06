using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StuDocs.Models
{
    public class Indeks
    {

        [Key()]
        [Required()]
        [StringLength(13, ErrorMessage = "Невалиден матичен број", MinimumLength = 13)]
        public virtual string embg { get; set; }

        [Display(Name = "Индекс број")]
        [Required()]
        public string index { get; set; }

        [Display(Name = "Факултет")]
        [Required()]
        public string faculty { get; set; }

        [Display(Name = "Студиска програма")]
        [Required()]
        public string programme { get; set; }

        [Display(Name = "Модул")]
        public string module { get; set; }

        [Display(Name = "Академска титула")]
        public string academicTitle { get; set; }

        [Display(Name = "Датум на упис")]
        DateTime enrollmentDate { get; set; }
    }
}
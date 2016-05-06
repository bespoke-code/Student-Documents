using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StuDocs.Models
{
    public class PrijavaZaIspit
    {
        [Key()]
        [Display(Name = "iKnow број на пријавата")]
        //[Required()]
        public string iknowBroj { get; set; }

        [Display(Name = "Факултет")]
        public string faculty { get; set; }

        [Display(Name = "Циклус на студии")]
        public string ciklus { get; set; }

        [Display(Name = "Студиска програма")]
        public string programa { get; set; }

        [Display(Name = "Модул")]
        public string modul { get; set; }

        [Display(Name = "Испитен рок")]
        public string ispitenRok { get; set; }

        [Display(Name = "Учебна година")]
        public uint uchebna { get; set; }

        [Display(Name = "Предмет")]
        [Required()]
        public string predmet { get; set; }

        [Display(Name = "Код на предметот")]
        public string kod { get; set; }

        [Display(Name = "Семестар и учебна година кога се слуша предметот")]
        public string semestar { get; set; }

        [Display(Name = "Кредити")]
        public uint krediti { get; set; }

        [Display(Name = "По кој пат се полага испитот")]
        public string polaganje { get; set; }

        [Display(Name = "Професор")]
        public string prof { get; set; }

        [Display(Name = "Асистент")]
        public string assistant { get; set; }

        [Display(Name = "Шифра за административна такса")]
        public string adminTaksa { get; set; }

    }
}
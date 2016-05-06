using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StuDocs.Models
{
    public class Student
    {
        [Display(Name = "Име")]
        [Required()]
        public string name { get; set; }

        [Display(Name = "Презиме")]
        [Required()]
        public string surname { get; set; }

        [Display(Name = "Име на родител")]
        [Required()]
        public string parentName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "e-mail адреса")]
        public string email { get; set; }

        [Display(Name = "Индекс")]
        public Indeks indeks { get; set; }

        [Required()]
        [Key]
        [Display(Name = "Матичен број")]
        [StringLength(13,ErrorMessage = "Невалиден матичен број", MinimumLength = 13)]
        public string embg { get; set; }

        [Display(Name = "Националност")]
        public string nationality { get; set; }

        [Display(Name = "Место на раѓање")]
        public Address birthAddress { get; set; }

        [Display(Name = "Домашна адреса")]
        public Address homeAddress { get; set; }

        [Display(Name = "Датум на раѓање")]
        public DateTime birthDate { get; set; }

        [Display(Name = "Телефонски број")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        //public PhoneNumber phone { get; set; }
    }
}
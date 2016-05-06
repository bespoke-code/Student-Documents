using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StuDocs.Models
{
    public class Address
    {
        //public string streetType { get; set; }
        [Display(Name = "Улица")]
        [Required()]
        public string streetName { get; set; }

        [Display(Name = "бр.")]
        [Required()]
        public string streetNo { get; set; }

        [Display(Name = "Населено место")]
        [Required()]
        public string placeName { get; set; }

        [Display(Name = "Општина")]
        public string municipalityName { get; set; }

        [Display(Name = "Држава")]
        [Required()]
        public string country { get; set; }

        [Display(Name = "Поштенски број")]
        [Required()]
        public string zipCode { get; set; }

    }
}
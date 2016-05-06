using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StuDocs.Models
{
    public class PhoneNumber
    {
        public string operatorPrefix { get; set; }
        public string areaPrefix { get; set; }
        public string number { get; set; }
        public bool mobile { get; set; }
    }
}
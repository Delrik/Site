using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Models
{
    public class CV
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Summary { get; set; }
        public string Objectives { get; set; }
        public string Jpg { get; set; }
    }
}

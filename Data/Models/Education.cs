using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Models
{
    public class Education
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string Degree { get; set; }
        public ushort Start { get; set; }
        public ushort End { get; set; }
        public int CVid { get; set; }
    }
}

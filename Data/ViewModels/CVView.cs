using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.ViewModels
{
    public class CVView
    {
        public CV cv { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        
    }
}

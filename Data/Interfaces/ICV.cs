using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Interfaces
{
    public interface ICV
    {
        CV GetCV { get; }
        List<Skill> Skills(int id);
        public List<Experience> Experiences(int id);
        List<Education> Educations(int id);
        List<Contact> Contacts(int id);
    }
}

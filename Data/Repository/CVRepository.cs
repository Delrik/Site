using Microsoft.EntityFrameworkCore;
using Site.Data.Interfaces;
using Site.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Data.Repository
{
    public class CVRepository : ICV
    {
        private readonly AppDBContent appDBContent;
        public CVRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public CV GetCV => appDBContent.Cv.Include(a => a).First();

        public List<Skill> Skills(int id) { return appDBContent.Skill.Where(a => a.CVid == id).ToList(); }

        public List<Experience> Experiences(int id) { return appDBContent.Experience.Where(a => a.CVid == id).ToList(); }

        public List<Education> Educations(int id) { return appDBContent.Education.Where(a => a.CVid == id).ToList(); }

        public List<Contact> Contacts(int id) { return appDBContent.Contact.Where(a => a.CVid == id).ToList(); }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CeeLearnAndDo.Models
{
    public class ContactAdmin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }

        //answer
        public string AnswerDescription { get; set; }
        public bool SiteDisplay { get; set; }
    }
    public class ContactAdminDBContext : DbContext
    {
        public DbSet<ContactAdmin> ContactAdmins { get; set; }
    }
}
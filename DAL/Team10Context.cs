using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using team10.Models;

namespace team10.DAL
{
    public class Team10Context : DbContext
    {
        public Team10Context(): base("DefaultConnection")
        {

        }
        public System.Data.Entity.DbSet<CentricUser> CentricUser { get; set; }
        public System.Data.Entity.DbSet<OfficeLocation> OfficeLocation { get; set; }
        public System.Data.Entity.DbSet<UserTitle> UserTitle { get; set; }
        public System.Data.Entity.DbSet<Cheer> Cheer { get; set; }

    }
}
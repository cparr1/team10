using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace team10.DAL
{
    public class Team10Context : DbContextTeam10
    {
        public Team10Context(): base("DefaultConnection")
        {

        }
    }
}
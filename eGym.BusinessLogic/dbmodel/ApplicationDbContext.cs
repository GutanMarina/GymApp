using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eGym.Domain.Entities.User;
using eGym.Domain.Entities;

namespace eGym.BusinessLogic.DBModel
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
            base("name = eGymLife")
        {
        }
        public DbSet<UDbTable> UDbTable { get; set; }

    }


}



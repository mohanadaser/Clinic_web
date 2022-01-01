using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic.Models.myDB
{
    public class myDBcontext:DbContext
    {
        public myDBcontext(DbContextOptions<myDBcontext> options) : base(options)
        {


        }

        public DbSet<patient> patients { get; set; }

        public DbSet<ADweya> aDweyas { get; set; }

        public DbSet<IRadat> iradats { get; set; }

        public DbSet<Masrofat> masrofats { get; set; }

        public DbSet<Setting> settings { get; set; }

        public DbSet<Online> onlines { get; set; }

        public DbSet<Users> users { get; set; }



    }
}

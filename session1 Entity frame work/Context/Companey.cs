using Microsoft.EntityFrameworkCore;
using session1_Entity_frame_work.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1_Entity_frame_work.Context
{
    internal class Companey :DbContext
    {
        public Companey():base() {
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G62R036\\VAMPRITA;Database=companey;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet <Employee> employees { get; set; }

        public DbSet<Depatment>  Depatments { get; set; }

    }
}

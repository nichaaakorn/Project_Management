using Microsoft.EntityFrameworkCore;
using ICONEXT.Models;


namespace ICONEXT.Data
{
    public class ICONEXTContext : DbContext
    {

        public DbSet<employee> employee { get; set; }

        public DbSet<outsource> outsource { get; set; }

        public DbSet<project> project { get; set; }

        public DbSet<Project_Phase> Project_Phase { get; set; }

        public DbSet<TaskProject> TaskProject { get; set; }

        public DbSet<PhaseProject> PhaseProject { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Leave> Leave { get; set; }

        public DbSet<JoinEmployee_Leave> JoinEmployee_Leave { get; set; }


        public ICONEXTContext(DbContextOptions options)
                 : base(options)
        {
        }




    }


}
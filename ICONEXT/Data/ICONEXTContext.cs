using Microsoft.EntityFrameworkCore;
using ICONEXT.Models;


namespace ICONEXT.Data
{
    public class ICONEXTContext : DbContext
    {


        public DbSet<employee> employee { get; set; }

        public DbSet<outsource> outsource { get; set; }

        public DbSet<project> project { get; set; }



        public DbSet<TaskProject> TaskProject { get; set; }

        public DbSet<PhaseProject> PhaseProject { get; set; }



    public ICONEXTContext(DbContextOptions options)
                 : base(options)
        {
        }




    }
}
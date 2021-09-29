using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Data
{
    
        public class DBContext : IdentityDbContext<IdentityUser>
        {
            public DBContext(DbContextOptions options) : base(options)
            {
            }


        //    public DbSet<Asst_referee_mast> Clients { get; set; }
        //    public DbSet<Coach_mast> Coach_masts { get; set; }
        //    public DbSet<Goal_detail> Goal_details { get; set; }
        //    public DbSet<Match_captain> Match_captains { get; set; }
        public DbSet<Match_details> Match_detailss { get; set; }
        //     public DbSet<Match_mast> Match_masts { get; set; }
        //    public DbSet<Penalty_gk> Penalty_gks { get; set; }
        //public DbSet<Penalty_shootout> Penalty_shootouts { get; set; }
        //public DbSet<Player_booked> Player_bookeds { get; set; }
        //public DbSet<Player_in_out> Player_in_outs { get; set; }
        public DbSet<Player_mast> Player_masts { get; set; }
        //public DbSet<Referee_mast> Referee_masts { get; set; }
        public DbSet<Soccer_City> Soccer_Citys { get; set; }
        public DbSet<Soccer_Country> Soccer_Countrys { get; set; }
        public DbSet<Soccer_Team> Soccer_Teams { get; set; }
        public DbSet<Soccer_Venue> Soccer_Venues { get; set; }
        //public DbSet<Team_coache> Team_coaches { get; set; }
    }

    
}

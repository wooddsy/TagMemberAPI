using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagMemberAPI.Data
{
    public class TAGMemberAPIContext : DbContext
    {
        public TAGMemberAPIContext(DbContextOptions<TAGMemberAPIContext>options)
            : base(options)
        {
        }
        public DbSet<Member> Members { get; set; }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<Warning> Warnings { get; set; }
    }
}

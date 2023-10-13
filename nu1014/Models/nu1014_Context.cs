using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace nu1014.Models
{
    public partial class nu1014_Context : DbContext
    {
        public nu1014_Context()
            : base("name=nu1014")
        {
        }

        public virtual DbSet<Org> Orgs { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Member> Members { get; set; }
    }
}
using MagicButton.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagicButton.Repository
{
    public class MagicButtonContext : DbContext
    {
        public DbSet<Counter> Counters { get; set; }
        public MagicButtonContext() : base("MagicButtonDB")
        {
            Database.SetInitializer(new MagicButtonInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class MagicButtonInitializer : DropCreateDatabaseIfModelChanges<MagicButtonContext>
    {
        protected override void Seed(MagicButtonContext context)
        {

            var counter = new Counter();
            context.Counters.Add(counter);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
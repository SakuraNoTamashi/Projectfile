using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
        protected override void OnModelCreating (ModelBuilder builder){
            builder.Entity<Value>().HasData(
                new Value{number=1,Id=1,Name="Value 101"},
                new Value{number=2,Id=2,Name="Value 102"},
                new Value{number=3,Id=3,Name="Value 103"}




            );


        }
    }
}

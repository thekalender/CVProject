using CVProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.DataAccess.Concrete.Entityframework.Context
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        // dbset<>
    }
}

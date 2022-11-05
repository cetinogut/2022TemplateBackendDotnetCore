using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class DasShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=2022DasShopTechNights;Trusted_Connection=true");
        }

        public DbSet<Basket> Baskets { get; set; }  //connect my entity Basket to the DB table Baskets
        public DbSet<Product> Products { get; set; }


    }
}

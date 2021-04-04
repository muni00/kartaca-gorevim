﻿using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DataAccess
{
   public class HotelDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-QOE1VTP\\MNBSERVER;Database = HotelDb; uid = sa;pwd=A2020d+-;");
        }
        
        public DbSet<Hotel> Hotels { get; set; }
    }
}

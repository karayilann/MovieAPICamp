﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoveAPI.Domain.Entities;

namespace MovieAPI.Persistence.Context
{
    public class MovieContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MAMIROG\\MAMIROG;initial catalog =ApiMovieDb;integrated security=true;TrustServerCertificate=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}

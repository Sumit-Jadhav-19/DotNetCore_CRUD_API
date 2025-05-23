﻿using DotNetCore_CRUD_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore_CRUD_API.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Product>().HasQueryFilter(p => !p.IsDeleted);
            base.OnModelCreating(model);
        }
    }
}

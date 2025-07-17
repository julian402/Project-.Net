using System;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Microsoft.Identity.Client;
using Infrastucture.Config;

namespace Infrastucture.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}

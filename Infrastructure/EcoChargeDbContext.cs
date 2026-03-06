using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class EcoChargeDbContext(DbContextOptions<EcoChargeDbContext> options) : DbContext(options)
    {
        public DbSet<EstacaoRecarga> EstacoesRecarga => Set<EstacaoRecarga>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EcoChargeDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}

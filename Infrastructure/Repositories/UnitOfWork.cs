using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class UnitOfWork(EcoChargeDbContext context) : IUnitOfWork
    {
        public async Task<bool> CommitAsync()
            => await context.SaveChangesAsync() > 0;
    }
}

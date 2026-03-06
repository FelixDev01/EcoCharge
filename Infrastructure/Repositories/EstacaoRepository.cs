using Domain.Entities;
using Domain.Interfaces;


namespace Infrastructure.Repositories
{
    public class EstacaoRepository(EcoChargeDbContext context) : IEstacaoRepository
    {
        public async Task<EstacaoRecarga?> ObterPorIdAsync(Guid id)
            => await context.EstacoesRecarga.FindAsync(id);

        public async Task AdicionarAsync(EstacaoRecarga estacao)
            => await context.EstacoesRecarga.AddAsync(estacao);

        public void Atualizar(EstacaoRecarga estacao)
            => context.EstacoesRecarga.Update(estacao);
    }
}

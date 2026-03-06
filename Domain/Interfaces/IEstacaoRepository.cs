using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IEstacaoRepository
    {
        Task<EstacaoRecarga?> ObterPorIdAsync(Guid id);
        Task AdicionarAsync(EstacaoRecarga estacao);
        void Atualizar(EstacaoRecarga estacao);
    }
}

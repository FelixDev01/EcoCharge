using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IEstacaoService
    {
        Task CriarEstacaoAsync(CriarEstacaoRequest request);
        Task IniciarRecargaAsync(Guid estacaoId);
        Task<EstacaoRecarga?> ObterPorIdAsync(Guid id);
    }
}

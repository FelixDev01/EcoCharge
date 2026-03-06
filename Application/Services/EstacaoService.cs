using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;

namespace EcoCharge.Application.Services;

public class EstacaoService(
    IEstacaoRepository repository,
    IUnitOfWork uow) : IEstacaoService
{
    public async Task CriarEstacaoAsync(CriarEstacaoRequest request)
    {
        var estacao = new EstacaoRecarga(request.Identificador, request.PotenciaKw);

        await repository.AdicionarAsync(estacao);
        await uow.CommitAsync();
    }

    public async Task IniciarRecargaAsync(Guid estacaoId)
    {
        var estacao = await repository.ObterPorIdAsync(estacaoId);

        if (estacao == null)
            throw new DomainException("Estação de recarga não encontrada.");

        estacao.IniciarRecarga();

        repository.Atualizar(estacao);
        await uow.CommitAsync();
    }
}
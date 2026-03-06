using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstacoesController(IEstacaoService service) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Criar(CriarEstacaoRequest request)
    {
        await service.CriarEstacaoAsync(request);
        return Ok(new { mensagem = "Estação criada com sucesso!" });
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Obter(Guid id)
    {
        var estacao = await service.ObterPorIdAsync(id);
        if (estacao == null) return NotFound();
        return Ok(estacao);
    }
}
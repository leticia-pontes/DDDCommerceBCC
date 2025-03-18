using DDDCommerceBCC.Domain.Entities;
using DDDCommerceBCC.Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDDCommerceBCC.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PedidoController : ControllerBase
{
    private readonly IPedidoRepository _pedidoRepository;

    public PedidoController(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    [HttpPost]
    public IActionResult Post(Pedido pedido)
    {
        _pedidoRepository.Adicionar(pedido);
        return CreatedAtAction(nameof(GetById), new { id = pedido.Id }, pedido);
    }

    [HttpGet]
    public IActionResult Get()
    {
        var pedidos = _pedidoRepository.Listar();
        return Ok(pedidos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var pedido = _pedidoRepository.ObterPorId(id);
        if (pedido == null) return NotFound("Pedido não encontrado!");
        return Ok(pedido);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Pedido pedidoAtualizado)
    {
        var pedido = _pedidoRepository.ObterPorId(id);
        if (pedido == null) return NotFound("Pedido não encontrado!");
        
        pedido.DataPedido = pedidoAtualizado.DataPedido;
        pedido.ValorTotal = pedidoAtualizado.ValorTotal;
        pedido.Itens = pedidoAtualizado.Itens;
        pedido.Status = pedidoAtualizado.Status;
        
        _pedidoRepository.Atualizar(pedido);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pedido = _pedidoRepository.ObterPorId(id);
        if (pedido == null) return NotFound("Pedido não encontrado!");
        
        _pedidoRepository.Remover(pedido);
        return NoContent();
    }
}
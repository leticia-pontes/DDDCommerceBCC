using DDDCommerceBCC.Domain.Entities;
using DDDCommerceBCC.Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDDCommerceBCC.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemPedidoController : ControllerBase
{
    private readonly IItemPedidoRepository _itemPedidoRepository;

    public ItemPedidoController(IItemPedidoRepository itemPedidoRepository)
    {
        _itemPedidoRepository = itemPedidoRepository;
    }

    [HttpPost]
    public IActionResult Post(ItemPedido itemPedido)
    {
        _itemPedidoRepository.Adicionar(itemPedido);
        return Ok("Item cadastrado com sucesso");
    }

    [HttpGet]
    public IActionResult Get()
    {
        var itemPedidos = _itemPedidoRepository.Listar();
        return Ok(itemPedidos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var itemPedido = _itemPedidoRepository.ObterPorId(id);
        if (itemPedido == null) return NotFound("Item não encontrado!");
        return Ok(itemPedido);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] ItemPedido itemPedidoAtualizado)
    {
        var itemPedido = _itemPedidoRepository.ObterPorId(id);

        if (itemPedido == null) return NotFound("Item não encontrado!");
        
        itemPedido.NomeProduto = itemPedidoAtualizado.NomeProduto;
        itemPedido.Quantidade = itemPedidoAtualizado.Quantidade;
        itemPedido.PrecoUnitario = itemPedidoAtualizado.PrecoUnitario;
        
        _itemPedidoRepository.Atualizar(itemPedido);
        
        return Ok("Item atualizado com sucesso!");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var itemPedido = _itemPedidoRepository.ObterPorId(id);
        if (itemPedido == null) return NotFound("Item não encontrado!");
        _itemPedidoRepository.Remover(itemPedido);
        return Ok("Item removido com sucesso!");
    }
}
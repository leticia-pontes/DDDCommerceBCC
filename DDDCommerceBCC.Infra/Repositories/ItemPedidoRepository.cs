using DDDCommerceBCC.Domain.Entities;
using DDDCommerceBCC.Infra.Data;
using DDDCommerceBCC.Infra.Interfaces;

namespace DDDCommerceBCC.Infra.Repositories;

public class ItemPedidoRepository : IItemPedidoRepository
{
    private readonly AppDbContext _context;

    public ItemPedidoRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Adicionar(ItemPedido itemPedido)
    {
        _context.ItensPedido.Add(itemPedido);
        _context.SaveChanges();
    }

    public List<ItemPedido> Listar()
    {
        return _context.ItensPedido.ToList();
    }

    public ItemPedido ObterPorId(int id)
    {
        var itemPedido = _context.ItensPedido
            .FirstOrDefault(p => p.Id == id);
        
        if (itemPedido == null)
            throw new KeyNotFoundException($"Item com ID {id} não foi encontrado!");
        
        return itemPedido;
    }

    public void Atualizar(ItemPedido itemPedido)
    {
        _context.ItensPedido.Update(itemPedido);
        _context.SaveChanges();
    }

    public void Remover(ItemPedido itemPedido)
    {
        _context.ItensPedido.Remove(itemPedido);
        _context.SaveChanges();
    }
}
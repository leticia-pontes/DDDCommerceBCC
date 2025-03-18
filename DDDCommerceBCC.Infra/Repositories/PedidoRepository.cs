using Microsoft.EntityFrameworkCore;
using DDDCommerceBCC.Domain.Entities;
using DDDCommerceBCC.Infra.Data;
using DDDCommerceBCC.Infra.Interfaces;

namespace DDDCommerceBCC.Infra.Repositories;

public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;

    public PedidoRepository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void Adicionar(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
    }

    public List<Pedido> Listar()
    {
        return _context.Pedidos
            .Include(p => p.Itens)
            .ToList();
    }

    public Pedido ObterPorId(int id)
    {
        var pedido = _context.Pedidos
            .Include(p => p.Itens)
            .SingleOrDefault(p => p.Id == id);

        if (pedido == null)
            throw new KeyNotFoundException($"Pedido com ID {id} não foi encontrado.");

        return pedido;
    }

    public void Atualizar(Pedido pedido)
    {
        _context.Pedidos.Update(pedido);
        _context.SaveChanges();
    }

    public void Remover(Pedido pedido)
    {
        _context.Pedidos.Remove(pedido);
        _context.SaveChanges();
    }
}
using DDDCommerceBCC.Domain.Entities;

namespace DDDCommerceBCC.Infra.Interfaces;

public interface IItemPedidoRepository
{
    public void Adicionar(ItemPedido itemPedido);
    public List<ItemPedido> Listar();
    public ItemPedido ObterPorId(int id);
    public void Atualizar(ItemPedido itemPedido);
    public void Remover(ItemPedido itemPedido);
}
using DDDCommerceBCC.Domain.Enums;

namespace DDDCommerceBCC.Domain.Entities;

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public List<ItemPedido> Itens { get; set; }
    public StatusPedido Status { get; set; }
}
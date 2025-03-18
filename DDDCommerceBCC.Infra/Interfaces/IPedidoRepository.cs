using DDDCommerceBCC.Domain.Entities;

namespace DDDCommerceBCC.Infra.Interfaces;

public interface IPedidoRepository
{
    public void Adicionar(Pedido pedido);
    public List<Pedido> Listar();
    public Pedido ObterPorId(int id);
    public void Atualizar(Pedido pedido);
    public void Remover(Pedido pedido);
}
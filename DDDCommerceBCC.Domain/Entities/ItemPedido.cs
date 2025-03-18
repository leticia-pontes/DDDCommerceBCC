namespace DDDCommerceBCC.Domain.Entities;

public class ItemPedido
{
    public int Id { get; set; }
    public string NomeProduto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
}
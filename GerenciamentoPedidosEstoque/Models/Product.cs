using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidosEstoque.Models;

public class Product
{
    [Required] public int Id { get; init; }
    [Required] public string Name { get; set; }
    public string? Description { get; set; }
    [Required] public float Price { get; set; }
    [Required] public int Quantity { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidosEstoque.Models;

public class Pedido
{
    [Required] public int Id { get; set; }
    [Required] public Cliente Owner { get; set; }
    [Required] public IEnumerable<Produto> Products { get; set; }
}
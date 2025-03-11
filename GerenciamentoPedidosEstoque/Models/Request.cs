using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidosEstoque.Models;

public class Request
{
    [Required] public int Id { get; set; }
    [Required] public Client Owner { get; set; }
    [Required] public IEnumerable<Product> Products { get; set; }
}
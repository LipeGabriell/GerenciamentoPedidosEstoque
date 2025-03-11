using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidosEstoque.Models;

public class Endereco
{
    [Required] public string Street { get; set; }
    [Required] public int Number { get; set; }
    [Required] public string City { get; set; }
    [Required] public string State { get; set; }
    [Required] public string Country { get; set; }
    [Required] public string Cep { get; set; }
}
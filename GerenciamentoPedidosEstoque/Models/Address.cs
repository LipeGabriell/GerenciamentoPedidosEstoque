using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoPedidosEstoque.Models;

public class Address
{
    [Key] [Required] public int Id { get; set; }
    [Required] public int ClientId { get; set; }

    [Required] public string Street { get; set; }
    [Required] public int Number { get; set; }
    [Required] public string City { get; set; }
    [Required] public string State { get; set; }
    [Required] public string Country { get; set; }
    [Required] public string Cep { get; set; }
}
﻿using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoPedidosEstoque.Models;

public class Client
{
    [Key] [Required] public int Id { get; set; }
    [Required] public string Name { get; set; }
    [EmailAddress] [Required] public string Email { get; set; }
    [Required] public string Cellphone { get; set; }
    [Required] public Address Address { get; set; }
}
using GerenciamentoPedidosEstoque.Contexts;
using GerenciamentoPedidosEstoque.Models;

namespace GerenciamentoPedidosEstoque.Repositories.ClientRepository;

public class ClientRepository(ApplicationDbContext context) : Repository<Client>(context), IClientRepository
{
}
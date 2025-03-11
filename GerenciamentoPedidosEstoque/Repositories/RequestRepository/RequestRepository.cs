using GerenciamentoPedidosEstoque.Contexts;
using GerenciamentoPedidosEstoque.Models;

namespace GerenciamentoPedidosEstoque.Repositories.RequestRepository;

public class RequestRepository(ApplicationDbContext context) : Repository<Request>(context), IRequestRepository
{
}
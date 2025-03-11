using GerenciamentoPedidosEstoque.Contexts;
using GerenciamentoPedidosEstoque.Models;

namespace GerenciamentoPedidosEstoque.Repositories.ProductRepository;

public class ProductRepository(ApplicationDbContext context) : Repository<Product>(context), IProductRepository
{
}
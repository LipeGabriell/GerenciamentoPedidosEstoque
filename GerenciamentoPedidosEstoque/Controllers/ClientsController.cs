using GerenciamentoPedidosEstoque.Models;
using GerenciamentoPedidosEstoque.Repositories.ClientRepository;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoPedidosEstoque.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController(IClientRepository repository) : Controller
{
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Client>> Get(int id)
    {
        var client = await repository.GetById(id);
        if (client == null) return NotFound($"Client not found with id: {id}");
        return Ok(client);
    }

    [HttpGet]
    public async Task<ActionResult<Client>> GetAll()
    {
        var clients = await repository.GetAll();
        if (clients == null) return NotFound("Clients not found");
        return Ok(clients);
    }

    [HttpPost]
    public async Task<ActionResult<Client>> Post(Client model)
    {
        var created = await repository.Create(model);
        if (created == null) return BadRequest(ModelState);
        return CreatedAtAction(nameof(Post), new { id = created.Id }, created);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var client = await repository.GetById(id);
        if (client == null) return NotFound($"Client not found with id: {id}");
        await repository.Delete(client);
        return NoContent();
    }
}
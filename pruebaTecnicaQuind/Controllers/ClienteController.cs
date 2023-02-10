using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pruebaTecnicaQuind.Models;

namespace pruebaTecnicaQuind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly PruebaContext _context;

        public ClienteController(PruebaContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("Lista")]

        public async Task<IActionResult> Lista()
        {
            List<Cliente> lista = await _context.Clientes.OrderByDescending(c => c.IdClientes).ToListAsync();
            return StatusCode (StatusCodes.Status200OK,lista);
        }

        [HttpPost]
        [Route("Guardar")]

        public async Task<IActionResult> Guardar([FromBody] Cliente request)
        {
            await _context.Clientes.AddAsync(request);
            await _context.SaveChangesAsync();
        }
    }


}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Twenty.BD.Data;
using Twenty.BD.Data.Entity;

namespace Twenty.Server.Controllers
{
    [ApiController]
    [Route("Twenty/Api/Cliente")]
    public class ClienteControllers : ControllerBase
    {
        private readonly Context context;

        public ClienteControllers(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> Get()
        {
            return await context.Clientes.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Cliente>> GetPorId (int id) 
        {
            var Existe = await context.Clientes.FirstOrDefaultAsync(x => x.Id == id);

            if (Existe == null)
            {
                return BadRequest($"El id {id} no coincide");
            }

            return Existe;
        }

        [HttpGet("Documento/{documento}")]

        public async Task<ActionResult<Cliente>> GetPorDocumento (string documento) 
        {
            var Existe = await context.Clientes.FirstOrDefaultAsync(x => x.Documento == documento);

            if (Existe == null)
            {
                return BadRequest($"El documento {documento} no coincide");
            }

            return Existe;
        }
    }
}

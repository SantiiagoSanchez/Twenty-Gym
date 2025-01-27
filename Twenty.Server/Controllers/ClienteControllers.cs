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

        [HttpPost]
        public async Task<ActionResult<int>> Post(Cliente entidad) 
        {
            try
            {
                context.Clientes.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cliente entidad) 
        {
            if (id != entidad.Id)
            {
                return BadRequest($"No hay un cliente con el ID {id}");
            }

            var EditarEntity = await context.Clientes.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (EditarEntity == null)
            {
                return NotFound("No se logro editar el Cliente");
            }

            EditarEntity.FotoPerfil = entidad.FotoPerfil;
            EditarEntity.Nombre = entidad.Nombre;
            EditarEntity.Documento = entidad.Documento;
            EditarEntity.Direccion = entidad.Direccion;
            EditarEntity.Telefono = entidad.Telefono;
            EditarEntity.Sexo = entidad.Sexo;
            EditarEntity.Edad = entidad.Edad;
            EditarEntity.FechaInscripcion = entidad.FechaInscripcion;
            EditarEntity.Cuota = entidad.Cuota;
            EditarEntity.Membresia = entidad.Membresia;
            EditarEntity.Email = entidad.Email;
            EditarEntity.Alergias = entidad.Alergias;
            EditarEntity.TelefonoEmergencia = entidad.TelefonoEmergencia;
            EditarEntity.EntrenadorId = entidad.EntrenadorId;
            EditarEntity.ActividadId = entidad.ActividadId;

            try
            {
                context.Clientes.Update(EditarEntity);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }   
    }
}

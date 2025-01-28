using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Twenty.BD.Data;
using Twenty.BD.Data.Entity;

namespace Twenty.Server.Controllers
{
    [ApiController]
    [Route("Twenty/Api/Dificultad")]
    public class DificultadControllers : ControllerBase
    {
        private readonly Context context;

        public DificultadControllers(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Dificultad>>> Get()
        {
            return await context.Dificultades.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Dificultad>> GetPorId(int id)
        {
            var Existe = await context.Dificultades.FirstOrDefaultAsync(x => x.Id == id);

            if (Existe == null)
            {
                return BadRequest($"El id {id} no coincide");
            }

            return Existe;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(Dificultad entidad)
        {
            try
            {
                context.Dificultades.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Dificultad entidad)
        {
            if (id != entidad.Id)
            {
                return BadRequest($"No hay una Dificultad con el ID {id}");
            }

            var EditarEntity = await context.Dificultades.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (EditarEntity == null)
            {
                return NotFound("No se logro editar la Dificultad");
            }

            EditarEntity.NivelDificultad = entidad.NivelDificultad;

            try
            {
                context.Dificultades.Update(EditarEntity);
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

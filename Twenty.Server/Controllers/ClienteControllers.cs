﻿using Microsoft.AspNetCore.Mvc;
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
    }
}

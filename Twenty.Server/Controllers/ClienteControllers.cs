using Microsoft.AspNetCore.Mvc;
using Twenty.BD.Data;

namespace Twenty.Server.Controllers
{
    [ApiController]
    public class ClienteControllers : ControllerBase
    {
        private readonly Context context;

        public ClienteControllers(Context context)
        {
            this.context = context;
        }
    }
}

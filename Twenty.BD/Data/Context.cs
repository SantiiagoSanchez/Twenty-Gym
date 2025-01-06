using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twenty.BD.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}

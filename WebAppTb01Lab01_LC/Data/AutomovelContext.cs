using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppTb01Lab01_LC.Models
{
    public class AutomovelContext : DbContext
    {
        public AutomovelContext (DbContextOptions<AutomovelContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppTb01Lab01_LC.Models.Automovel> Automovel { get; set; }
    }
}

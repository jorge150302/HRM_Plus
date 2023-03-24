using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRM_Plus.Models;

namespace HRM_Plus.Data
{
    public class HRM_PlusContext : DbContext
    {
        public HRM_PlusContext (DbContextOptions<HRM_PlusContext> options)
            : base(options)
        {
        }

        public DbSet<HRM_Plus.Models.Puesto> Puesto { get; set; } = default!;
    }
}

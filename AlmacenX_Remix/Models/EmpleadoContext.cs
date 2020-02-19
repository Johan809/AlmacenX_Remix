using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmacenX_Remix.Models
{
    public class EmpleadoContext : DbContext 
    {
        public EmpleadoContext(DbContextOptions<EmpleadoContext> options): base(options)
        {}

        public DbSet<Empleado> Empleados { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inmobiliaria.Models;

namespace Inmobiliaria.Context
{
    public class InmobiliariaDatabaseContext : DbContext
    {
        public InmobiliariaDatabaseContext(DbContextOptions<InmobiliariaDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Inmueble> Inmuebles { get; set; }

        public DbSet<Publicacion> Publicaciones { get; set; }

        public DbSet<Formulario> Formularios { get; set; }

        public DbSet<Inmobiliaria.Models.Administrador> Administrador { get; set; }

    }
}

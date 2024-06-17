using ClienteAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Clientewas.Contexto
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
        : base(options) { }

        public  DbSet<Articulos> Articulos { get; set; }
    }
}

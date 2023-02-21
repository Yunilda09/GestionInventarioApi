using Microsoft.EntityFrameworkCore;
using GestionInventarioApi.Models;

namespace GestionInventarioApi.Data
{
    public class Contexto: DbContext
    {
        public DbSet<Articulos> Articulos => Set<Articulos>();


        public Contexto(DbContextOptions<Contexto> options)
            : base(options) { }
    }
}
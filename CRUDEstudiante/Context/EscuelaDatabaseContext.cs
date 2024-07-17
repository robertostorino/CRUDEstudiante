using CRUDEstudiante.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


// Esta clase Context es como la conexión a la base de datos
namespace CRUDEstudiante.Context
{
    public class EscuelaDatabaseContext : DbContext
    {
        public EscuelaDatabaseContext(DbContextOptions<EscuelaDatabaseContext> options) : base(options)
        {
        }

        // El DbSet de EF es equivalente a un tipo List
        // Voy mapeando los objetos del negocio que serán tablas de la base de datos
        public DbSet<Estudiante> Estudiantes { get; set; } // DbSet sería equivalente a la tabla de la base de datos
                                                           // Dice la tabla Estudiantes que está en la base de datos, la voy a mapear a mi objeto Estudiantes
    }
}

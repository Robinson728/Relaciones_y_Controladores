using Microsoft.EntityFrameworkCore;
using Relaciones_y_Controladores_Leccion3.Models.DataModels;

namespace Relaciones_y_Controladores_Leccion3.DAL
{
    public class ProyectContext : DbContext
    {
        public DbSet<Users>? User { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }


        public ProyectContext(DbContextOptions<ProyectContext> options): base(options)
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace app_formulario_crud.Models
{
    public class DataBase : DbContext
    {
        public DataBase(DbContextOptions options) : base(options) { }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Horario> Horario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=appformulariodb;Integrated Security=True");
        }
    }
}

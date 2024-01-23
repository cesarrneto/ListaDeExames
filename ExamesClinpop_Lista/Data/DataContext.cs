using Microsoft.EntityFrameworkCore;

namespace ExamesClinpop_Lista.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exame>().HasData(
                new Exame
                {
                    ExameId = 1,
                    NomeExame = "V.D.R.L",
                    DescricaoExame = "Exame de Sangue",
                    PrecoExame = 6
                });
        }

        public DbSet<Exame> Exames { get; set; }
    }
}

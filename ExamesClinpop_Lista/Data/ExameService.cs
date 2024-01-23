using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace ExamesClinpop_Lista.Data
{
    public class ExameService : IExameService
    {
        private readonly DataContext _context;
        private readonly NavigationManager _navigationManager;
        public ExameService(DataContext context, NavigationManager navigationManager )
        {

            _context = context;
            _navigationManager = navigationManager;
            _context.Database.EnsureCreated();
            
        }

        public List<Exame> Exames { get; set; } = new List<Exame>();
        public async Task CreateExame(Exame exame)
        {
            try
            {
                _context.Add(exame);
                await _context.SaveChangesAsync();
                _navigationManager.NavigateTo("exame");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteExame(int exameId)
        {
            var dbExame = await _context.Exames.FindAsync(exameId);
			if (dbExame == null)
            {
                throw new Exception("Nenhum exame cadastrado!");
            }

            _context.Remove(dbExame);
            await _context.SaveChangesAsync();
            _navigationManager.NavigateTo("exame");
        }

        public async Task<Exame> GetExameById(int exameId)
        {
            var dbExame = await _context.Exames.FindAsync(exameId);
			if (dbExame == null)
			{
				throw new Exception("Nenhum exame cadastrado!");
            }
            return dbExame;
            
        }

        public async Task GetExames()
        {
            Exames = await _context.Exames.ToListAsync();         
            
        }

        public async Task UpdateExame(int exameId, Exame exame)
        {
            var dbExame = await _context.Exames.FindAsync(exameId);
            if (dbExame != null)
            {
                dbExame.NomeExame = exame.NomeExame;
                dbExame.DescricaoExame = exame.DescricaoExame;
                dbExame.PrecoExame = exame.PrecoExame;

                await _context.SaveChangesAsync();
                _navigationManager.NavigateTo("exame");
            }

        }
    }
}
namespace ExamesClinpop_Lista.Data
{
    public interface IExameService
    {
        List<Exame> Exames { get; set; }
        Task GetExames();
        Task <Exame> GetExameById(int exameId);
        Task CreateExame(Exame exame);
        Task UpdateExame(int exameId, Exame exame);
        Task DeleteExame(int exameId);
    }
}

using ONGLIVES.API.Entidades;

public interface IOngRepository
{
    public Task<List<Ong>> PegarTodos();
    public Task<Ong> Cadastrar(Ong ong);
    public Task<Ong> PegarPorId(int id);
    public Task<Ong> PegarPorNome(string nome);
    public Task<Ong> Editar(EditOngModel ong);
    public Task Deletar(Ong ong);
}
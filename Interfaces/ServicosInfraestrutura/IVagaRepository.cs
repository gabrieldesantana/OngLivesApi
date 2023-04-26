using ONGLIVES.API.Entidades;

public interface IVagaRepository 
{
    public Task<List<Vaga>> PegarTodos();
    public Task<Vaga> PegarPorId(int id);
    public Task<Vaga> Cadastrar(Vaga vaga);
    public Task<Vaga> Editar(EditVagaModel vaga);
    public Task Deletar(Vaga vaga);
}
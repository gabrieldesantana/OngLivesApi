using ONGLIVES.API.Entidades;

public interface IVagaRepository 
{
    public List<Vaga> PegarTodos();
    public Vaga Cadastrar(Vaga vaga);
    public Vaga PegarPorId(int id);
    public Vaga Editar(Vaga vaga);
    public Vaga Deletar(Vaga vaga);
}
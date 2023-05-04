using ONGLIVES.API.Entidades;

public interface IExperienciaRepository 
{
    public Task<List<Experiencia>> PegarTodos();
    public Task<Experiencia> Cadastrar(Experiencia experiencia);
    public Task<Experiencia> PegarPorId(int id);
    public Task<Experiencia> Editar(EditExperienciaModel experiencia);
    public Task Deletar(Experiencia experiencia);
}

using ONGLIVES.API.Entidades;

//public interface IVoluntarioRepository : IGenericRepository<Voluntario>
public interface IVoluntarioRepository 
{
    public Task<List<Voluntario>> PegarTodos();
    public Task<Voluntario> PegarPorId(int id);
    public Task<Voluntario> Cadastrar(Voluntario voluntario);
    public Task<Voluntario> Editar (EditVoluntarioModel voluntario);
    public Task Deletar(Voluntario voluntario);
}
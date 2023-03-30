using ONGLIVES.API.Entidades;

public interface IExperienciaRepository 
{
    public List<Experiencia> PegarTodos();
    public Experiencia Cadastrar(Experiencia experiencia);
    public Experiencia PegarPorId(int id);
    public Experiencia Editar(Experiencia experiencia);
    public Experiencia Deletar(Experiencia experiencia);
}

using ONGLIVES.API.Entidades;

public interface IVoluntarioRepository 
{
    public List<Voluntario> PegarTodos();
    public Voluntario Cadastrar(Voluntario voluntario);
    public Voluntario PegarPorId(int id);
    public Voluntario Editar (Voluntario voluntario);
    public void Deletar(int id);
}
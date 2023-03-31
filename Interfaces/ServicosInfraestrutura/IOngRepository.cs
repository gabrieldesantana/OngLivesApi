using ONGLIVES.API.Entidades;

public interface IOngRepository
{
    public List<Ong> PegarTodos();
    public Ong Cadastrar(Ong ong);
    public Ong PegarPorId(int id);
    public Ong Editar(Ong ong);
    public void Deletar(int id);
}
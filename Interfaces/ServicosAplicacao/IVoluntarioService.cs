using ONGLIVES.API.Entidades;

namespace ONGLIVESAPI.Interfaces;

public interface IVoluntarioService 
{
    public List<Voluntario> PegarTodos();
    public Voluntario PegarPorId(int id);
    public Voluntario Cadastrar(Voluntario voluntario);
    public Voluntario Editar(Voluntario voluntario);
    public void Deletar(int id);

}
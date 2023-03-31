using ONGLIVES.API.Entidades;

namespace ONGLIVESAPI.Interfaces;

public interface IOngService
{
    public List<Ong> PegarTodos();
    public Ong Cadastrar(Ong ong);
    public Ong Editar(Ong ong);
    public void Deletar(int id);

}
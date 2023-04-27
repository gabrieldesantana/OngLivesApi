using ONGLIVES.API.Entidades;

namespace ONGLIVESAPI.Interfaces;

public interface IOngService
{
    public Task<List<Ong>> PegarTodos();
    public Task<Ong> Cadastrar(Ong ong);
    public Task<Ong> Editar(EditOngModel ong);
    public Task<bool> Deletar(int id);
    public Task<Ong> PegarPorId(int id);
}
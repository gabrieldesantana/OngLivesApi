using ONGLIVES.API.Entidades;

namespace ONGLIVESAPI.Interfaces;
public interface IVagaService 
{
    public Task<List<Vaga>> PegarTodos();
    public Task<Vaga> PegarPorId(int id);
    public Task<Vaga> Cadastrar(Vaga vaga);
    public Task<Vaga> Editar(EditVagaModel vaga);
    public Task<bool> Deletar(int id);
    
}
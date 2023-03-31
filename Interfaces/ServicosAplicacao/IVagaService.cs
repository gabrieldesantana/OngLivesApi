using ONGLIVES.API.Entidades;

namespace ONGLIVESAPI.Interfaces;
public interface IVagaService 
{
    public List<Vaga> PegarTodos();
    public Vaga Cadastrar(Vaga vaga);
    public Vaga Editar(Vaga vaga);
    public void Deletar(int id);
}
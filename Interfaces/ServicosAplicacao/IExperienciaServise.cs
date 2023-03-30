using ONGLIVES.API.Entidades;

namespace ONGLIVESAPI.Interfaces;
public interface IExperienciaService 
{
      public List<Experiencia> PegarTodos();
    public Experiencia Cadastrar(Experiencia experiencia);
    public Experiencia Editar(Experiencia experiencia);
    public void Deletar(Experiencia experiencia);

}
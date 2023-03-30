using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class ExperienciaService : IExperienciaService
{
    private readonly IExperienciaRepository _repository;
    public ExperienciaService(IExperienciaRepository repository)
    {
        _repository = repository;
    }
    public Experiencia Cadastrar(Experiencia voluntario)
    {
        var voluntarios = _repository.PegarTodos();
        //validacoes
        if (voluntario == null)
            throw new Exception("Experiencia sem informacoes");

        if (voluntarios.Exists(x => x.Id == voluntario.Id))
            throw new Exception("ExperienciaId já existe");

        _repository.Cadastrar(voluntario);
        return voluntario;
    }

    public void Deletar(Experiencia voluntario)
    {
        throw new NotImplementedException();
    }

    public Experiencia Editar(Experiencia voluntario)
    {
        throw new NotImplementedException();
    }

    public List<Experiencia> PegarTodos()
    {
        return _repository.PegarTodos();
    }
}
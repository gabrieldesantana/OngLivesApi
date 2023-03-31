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
            throw new Exception("ExperienciaId ja existe");

        _repository.Cadastrar(voluntario);
        return voluntario;
    }

    public void Deletar(int id)
    {
        _repository.Deletar(id);
    }

    public Experiencia Editar(Experiencia experiencia)
    {
        var experienciaEdit = _repository.Editar(experiencia);
        return experienciaEdit;
    }

    public Experiencia PegarPorId(int id)
    {
        return _repository.PegarPorId(id);
    }

    public List<Experiencia> PegarTodos()
    {
        return _repository.PegarTodos();
    }
}
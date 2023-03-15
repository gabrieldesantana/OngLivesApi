using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class VoluntarioService : IVoluntarioService
{
    private readonly IVoluntarioRepository _repository;
    public VoluntarioService(IVoluntarioRepository repository)
    {
        _repository = repository;
    }
    public Voluntario Cadastrar(Voluntario voluntario)
    {
        var voluntarios = _repository.PegarTodos();
        //validacoes
        if (voluntario == null)
            throw new Exception("Voluntario sem informacoes");

        if (voluntarios.Exists(x => x.Id == voluntario.Id))
            throw new Exception("VoluntarioId já existe");

        _repository.Cadastrar(voluntario);
        return voluntario;
    }

    public void Deletar(Voluntario voluntario)
    {
        throw new NotImplementedException();
    }

    public Voluntario Editar(Voluntario voluntario)
    {
        throw new NotImplementedException();
    }

    public List<Voluntario> PegarTodos()
    {
        return _repository.PegarTodos();
    }
}
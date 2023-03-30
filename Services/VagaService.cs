using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class VagaService : IVagaService
{
    private readonly IVagaRepository _repository;
    public VagaService(IVagaRepository repository)
    {
        _repository = repository;
    }
    public Vaga Cadastrar(Vaga voluntario)
    {
        var voluntarios = _repository.PegarTodos();
        //validacoes
        if (voluntario == null)
            throw new Exception("Vaga sem informacoes");

        if (voluntarios.Exists(x => x.Id == voluntario.Id))
            throw new Exception("VagaId já existe");

        _repository.Cadastrar(voluntario);
        return voluntario;
    }

    public void Deletar(Vaga voluntario)
    {
        throw new NotImplementedException();
    }

    public Vaga Editar(Vaga voluntario)
    {
        throw new NotImplementedException();
    }

    public List<Vaga> PegarTodos()
    {
        return _repository.PegarTodos();
    }
}
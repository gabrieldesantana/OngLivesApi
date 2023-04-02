using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class VagaService : IVagaService
{
    private readonly IVagaRepository _repository;
    public VagaService(IVagaRepository repository)
    {
        _repository = repository;
    }
    public Vaga Cadastrar(Vaga vaga)
    {
        var vagas = _repository.PegarTodos();
        //validacoes
        if (vaga == null)
            throw new Exception("Vaga sem informacoes");

        if (vagas.Exists(x => x.Id == vaga.Id))
            throw new Exception("VagaId ja existe");

        _repository.Cadastrar(vaga);
        return vaga;
    }

    public void Deletar(int id)
    {
        _repository.Deletar(id);
    }

    public Vaga Editar(Vaga vaga)
    {
        var vagaEdit = _repository.Editar(vaga);
        return vagaEdit;
    }

    public List<Vaga> PegarTodos()
    {
        return _repository.PegarTodos();
    }

    public Vaga PegarPorId(int id)
    {
        return _repository.PegarPorId(id);
    }
}
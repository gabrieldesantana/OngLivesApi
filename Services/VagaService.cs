using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class VagaService : IVagaService
{
    private readonly IVagaRepository _repository;
    public VagaService(IVagaRepository repository)
    {
        _repository = repository;
    }
    public async Task<Vaga> Cadastrar(Vaga vaga)
    {
        var vagas = await _repository.PegarTodos();
        //validacoes
        if (vaga == null)
            throw new Exception("Vaga sem informações");

        if (vagas.Exists(x => x.Id == vaga.Id))
            throw new Exception("VagaId ja existe");

        _repository.Cadastrar(vaga);

        return vaga;
    }

    public async Task<Vaga> Editar(EditVagaModel vaga)
    {
        var vagaEdit = await _repository.PegarPorId(vaga.Id);
        
        if (vagaEdit == null)
            return null;
        
        vagaEdit = await _repository.Editar(vaga);

        return vagaEdit;
    }

    public async Task<List<Vaga>> PegarTodos()
    {
        return await _repository.PegarTodos();
    }

    public async Task<Vaga> PegarPorId(int id)
    {
        var vaga = await _repository.PegarPorId(id);

        if (vaga == null)
            return null;

        return await _repository.PegarPorId(id);
    }

    public async Task<bool> Deletar(int id)
    {
        var vaga = await _repository.PegarPorId(id);

        if (vaga == null)
            return false;
            //return Boolean
        await _repository.Deletar(vaga);
        return true;
    }
}
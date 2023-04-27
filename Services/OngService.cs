using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class OngService : IOngService
{
    private readonly IOngRepository _repository;
    public OngService(IOngRepository repository)
    {
        _repository = repository;
    }
    public async Task<Ong> Cadastrar(Ong ong)
    {
        var ongs = await _repository.PegarTodos();
        //validacoes
        if (ong == null)
            throw new Exception("Ong sem informações");

        if (ongs.Exists(x => x.Id == ong.Id))
            throw new Exception("OngId já existe");

        _repository.Cadastrar(ong);
        return ong;
    }

    public async Task<Ong> Editar(EditOngModel ong)
    {
        var ongEdit = await _repository.PegarPorId(ong.Id);

        if (ongEdit == null)
            return null;

        ongEdit = await _repository.Editar(ong);

        return ongEdit;
    }

    public async Task<List<Ong>> PegarTodos()
    {
        return await _repository.PegarTodos();
    }

    public async Task<Ong> PegarPorId(int id)
    {
        var ong = await _repository.PegarPorId(id);

        if (ong == null)
            return null;

        return await _repository.PegarPorId(id);
    }

    public async Task<bool> Deletar(int id)
    {
        var voluntario = await _repository.PegarPorId(id);

        if (voluntario == null)
            return false;
        //return Boolean
        await _repository.Deletar(voluntario);
        return true;
    }
}
using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class OngService : IOngService
{
    private readonly IOngRepository _repository;
    public OngService(IOngRepository repository)
    {
        _repository = repository;
    }
    public Ong Cadastrar(Ong ong)
    {
        var ongs = _repository.PegarTodos();
        //validacoes
        if (ongs == null)
            throw new Exception("Ong sem informações");

        if (ongs.Exists(x => x.Id == ong.Id))
            throw new Exception("OngId já existe");

        _repository.Cadastrar(ong);
        return ong;
    }

    public void Deletar(int id)
    {
        _repository.Deletar(id);
    }

    public Ong Editar(Ong ong)
    {
        var ongEdit = _repository.Editar(ong);
        return ongEdit;
    }

    public List<Ong> PegarTodos()
    {
        return _repository.PegarTodos();
    }

    public Ong PegarPorId(int id)
    {
        return _repository.PegarPorId(id);
    }
}
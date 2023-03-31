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
        var ong = _repository.PegarTodos();
        //validacoes
        if (ong == null)
            throw new Exception("Ong sem informacoes");

        if (ong.Exists(x => x.Id == voluntario.Id))
            throw new Exception("OngId já existe");

        _repository.Cadastrar(ong);
        return ong;
    }

    public void Deletar(Ong ong)
    {
        throw new NotImplementedException();
    }

    public Ong Editar(Ong ong)
    {
        throw new NotImplementedException();
    }

    public List<Ong> PegarTodos()
    {
        return _repository.PegarTodos();
    }
}
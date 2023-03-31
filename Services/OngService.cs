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
            throw new Exception("Ong sem informacoes");

        if (ongs.Exists(x => x.Id == ong.Id))
            throw new Exception("OngId já existe");

        _repository.Cadastrar(ong);
        return ong;
    }


    public void Deletar(int id)
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
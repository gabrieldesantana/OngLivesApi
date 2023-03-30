using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class OngRepository : IOngRepository
{
    private readonly OngLivesContext _context;

    public OngRepository(OngLivesContext context)
    {
        _context = context;
    }
    public Ong Cadastrar(Ong ong)
    {
        _context.Ongs.Add(ong);
        return ong;
    }

    public Ong Deletar(Ong ong)
    {
        throw new NotImplementedException();
    }

    public Ong Editar(Ong ong)
    {
        throw new NotImplementedException();
    }

    public Ong PegarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Ong> PegarTodos()
    {
        return _context.Ongs.ToList();
    }
}
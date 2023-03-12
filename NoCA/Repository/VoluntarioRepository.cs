using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class VoluntarioRepository : IVoluntarioRepository
{
    private readonly OngLivesContext _context;

    public VoluntarioRepository(OngLivesContext context)
    {
        _context = context;
    }
    public Voluntario Cadastrar(Voluntario voluntario)
    {
        _context.Voluntarios.Add(voluntario);
        return voluntario;
    }

    public Voluntario Deletar(Voluntario voluntario)
    {
        throw new NotImplementedException();
    }

    public Voluntario Editar(Voluntario voluntario)
    {
        throw new NotImplementedException();
    }

    public Voluntario PegarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Voluntario> PegarTodos()
    {
        return _context.Voluntarios.ToList();
    }
}
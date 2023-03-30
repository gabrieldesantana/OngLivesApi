using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class ExperienciaRepository : IExperienciaRepository
{
    private readonly OngLivesContext _context;

    public ExperienciaRepository(OngLivesContext context)
    {
        _context = context;
    }
    public Experiencia Cadastrar(Experiencia voluntario)
    {
        _context.Experiencias.Add(voluntario);
        return voluntario;
    }

    public Experiencia Deletar(Experiencia voluntario)
    {
        throw new NotImplementedException();
    }

    public Experiencia Editar(Experiencia voluntario)
    {
        throw new NotImplementedException();
    }

    public Experiencia PegarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Experiencia> PegarTodos()
    {
        return _context.Experiencias.ToList();
    }
}
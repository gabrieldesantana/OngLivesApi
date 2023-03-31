using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class VagaRepository : IVagaRepository
{
    private readonly OngLivesContext _context;

    public VagaRepository(OngLivesContext context)
    {
        _context = context;
    }
    public Vaga Cadastrar(Vaga voluntario)
    {
        _context.Vagas.Add(voluntario);
        return voluntario;
    }

    public void Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Vaga Editar(Vaga voluntario)
    {
        throw new NotImplementedException();
    }

    public Vaga PegarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Vaga> PegarTodos()
    {
        return _context.Vagas.ToList();
    }
}
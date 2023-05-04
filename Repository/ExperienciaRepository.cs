using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class ExperienciaRepository : IExperienciaRepository
{
    private readonly OngLivesContext _context;

    public ExperienciaRepository(OngLivesContext context)
    {
        _context = context;
    }
    public async Task<Experiencia> Cadastrar(Experiencia voluntario)
    {
        _context.Experiencias.Add(voluntario);
        return voluntario;
    }

    public async Task Deletar(Experiencia experiencia)
    {
        _context.Experiencias.Remove(experiencia);
    }

    public async Task<Experiencia> Editar(EditExperienciaModel experiencia)
    {
        var experienciaEdit = await PegarPorId(experiencia.Id);

        experienciaEdit.IdVoluntario = experiencia.IdVoluntario;
        experienciaEdit.IdOng = experiencia.IdOng;
        experienciaEdit.ProjetoEnvolvido = experiencia.ProjetoEnvolvido;
        experienciaEdit.Opiniao = experiencia.Opiniao;

        return experienciaEdit;

    }

    public async Task<Experiencia> PegarPorId(int id)
    {
        return _context.Experiencias.FirstOrDefault(x => x.Id == id);
    }

    public async Task<List<Experiencia>> PegarTodos()
    {
        return _context.Experiencias.ToList();
    }
}
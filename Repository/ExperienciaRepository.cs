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

    public void Deletar(int id)
    {
        var experiencia = PegarPorId(id);
        _context.Experiencias.Remove(experiencia);
    }

    public Experiencia Editar(Experiencia experiencia)
    {
        var experienciaEdit = PegarPorId(experiencia.Id);

        experienciaEdit.IdVoluntario = experiencia.IdVoluntario;
        experienciaEdit.NomeVoluntario = experiencia.NomeVoluntario;
        experienciaEdit.IdVoluntario = experiencia.IdVoluntario;
        experienciaEdit.IdOng = experiencia.IdOng;
        experienciaEdit.NomeOng = experiencia.NomeOng;
        experienciaEdit.ProjetoEnvolvido = experiencia.ProjetoEnvolvido;
        experienciaEdit.Opiniao = experiencia.Opiniao;
        experienciaEdit.Data = experiencia.Data;
        return experienciaEdit;

    }

    public Experiencia PegarPorId(int id)
    {
        return _context.Experiencias.FirstOrDefault(x => x.Id == id);
    }

    public List<Experiencia> PegarTodos()
    {
        return _context.Experiencias.ToList();
    }
}
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

    public void Deletar(int id)
    {
        var voluntario = PegarPorId(id);
        _context.Voluntarios.Remove(voluntario);
    }

    public Voluntario Editar(Voluntario voluntario)
    {
        var voluntarioEdit = PegarPorId(voluntario.Id);

        voluntarioEdit.Nome = voluntario.Nome;
        voluntarioEdit.CPF = voluntario.CPF;
        voluntarioEdit.DataAniversario = voluntario.DataAniversario;
        voluntarioEdit.Email = voluntario.Email;
        voluntarioEdit.Telefone = voluntario.Telefone;
        voluntarioEdit.Escolaridade = voluntario.Escolaridade;
        voluntarioEdit.Genero = voluntario.Genero;
        voluntarioEdit.Habilidade = voluntario.Habilidade;
        voluntarioEdit.HorasVoluntaria = voluntario.HorasVoluntaria;
        voluntarioEdit.QuantidadeExperiencias = voluntario.QuantidadeExperiencias;
        voluntarioEdit.Endereco = voluntario.Endereco;
        return voluntarioEdit;

    }

    public Voluntario PegarPorId(int id)
    {
        return _context.Voluntarios.FirstOrDefault(x => x.Id == id);
    }

    public List<Voluntario> PegarTodos()
    {
        return _context.Voluntarios.ToList();
    }
}
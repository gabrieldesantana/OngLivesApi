using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

//public class VoluntarioRepository : GenericRepository<Voluntario>, IVoluntarioRepository
public class VoluntarioRepository : IVoluntarioRepository
{
    private readonly OngLivesContext _context;

    public VoluntarioRepository(OngLivesContext context)
    {
        _context = context;
    }
    //public VoluntarioRepository(OngLivesContext context) 
    //    : base(context)
    //{
    //}

    public async Task<Voluntario> Cadastrar(Voluntario voluntario) 
    {
        _context.Voluntarios.Add(voluntario);
        return voluntario;
    }

    public async Task Deletar(Voluntario voluntario)
    {
        _context.Voluntarios.Remove(voluntario);
    }


    public async Task<Voluntario> Editar(EditVoluntarioModel voluntario)
    {
        var voluntarioEdit = await PegarPorId(voluntario.Id);

        // voluntarioEdit.Nome = voluntario.Nome;
        // voluntarioEdit.CPF = voluntario.CPF;
        // voluntarioEdit.DataNascimento = voluntario.DataNascimento;
        voluntarioEdit.Email = voluntario.Email;
        voluntarioEdit.Telefone = voluntario.Telefone;
        voluntarioEdit.Escolaridade = voluntario.Escolaridade;
        // voluntarioEdit.Genero = voluntario.Genero;
        voluntarioEdit.Habilidade = voluntario.Habilidade;
        voluntarioEdit.HorasVoluntaria = voluntario.HorasVoluntaria;
        voluntarioEdit.QuantidadeExperiencias = voluntario.QuantidadeExperiencias;
        voluntarioEdit.Endereco = voluntario.Endereco;
        voluntarioEdit.Avaliacao = voluntario.Avaliacao;
        return voluntarioEdit;

    }

    public async Task<Voluntario> PegarPorId(int id)
    {
        return  _context.Voluntarios.FirstOrDefault(x => x.Id == id);
    }

    public async Task<List<Voluntario>> PegarTodos()
    {
        return _context.Voluntarios.ToList();
    }
}



//public IEnumerable<Customer> GetByName(string name)
//{
//    return _entities.Where(c => c.Name.Contains(name)).ToList();
//}
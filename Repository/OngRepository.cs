using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class OngRepository : IOngRepository
{
    private readonly OngLivesContext _context;

    public OngRepository(OngLivesContext context)
    {
        _context = context;
    }
    public async Task<Ong> Cadastrar(Ong ong)
    {
        _context.Ongs.Add(ong);
        return ong;
    }

    public async Task Deletar(Ong ong)
    {
        _context.Ongs.Remove(ong);
    }

    public async Task<Ong> Editar(EditOngModel ong)
    {
        var ongEdit = await PegarPorId(ong.Id);

        ongEdit.Telefone = ong.Telefone;
        ongEdit.Email = ong.Email;
        ongEdit.QuantidadeEmpregados = ong.QuantidadeEmpregados;
        ongEdit.Endereco = ong.Endereco;
        
        return ongEdit;
    }

    public async Task<Ong> PegarPorId(int id)
    {
        return _context.Ongs.FirstOrDefault(x => x.Id == id);
    }

    public async Task<Ong> PegarPorNome(string nome)
    {
        if (!string.IsNullOrWhiteSpace(nome))
        {
            //return _context.Voluntarios.Where( x => x.Nome.Contains(nome) && x.Sobrenome.Contains(sobrenome)).ToList();
            return _context.Ongs.FirstOrDefault(x => x.Nome.Contains(nome) && x.Nome.Contains(nome));
        }   
        return null;
    }


    public async Task<List<Ong>> PegarTodos()
    {
        return _context.Ongs.ToList();
    }
}
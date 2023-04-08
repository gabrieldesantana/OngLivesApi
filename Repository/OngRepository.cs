using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class OngRepository : IOngRepository
{
    private readonly OngLivesContext _context;

    public OngRepository(OngLivesContext context)
    {
        _context = context;
    }
    public async Task<Ong> Cadastrar(Voluntario voluntario)
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
        var ongsEdit = PegarPorId(ongs.Id);

        ongsEdit.Nome = ongs.Nome;
        ongsEdit.CNPJ = ongs.CNPJ;
        ongsEdit.Email = ongs.Email;
        ongsEdit.Telefone = ongs.Telefone;
        ongsEdit.AreaAtuacao = ongs.AreaAtuacao;
        ongsEdit.Endereco = ongs.Endereco;
        return ongsEdit;

    }

    public async Task<Ong> PegarPorId(int id)
    {
        return _context.Ongs.FirstOrDefault(x => x.Id == id);
    }

    public async Task<List<Ong>> PegarTodos()
    {
        return _context.Ongs.ToList();
    }
}
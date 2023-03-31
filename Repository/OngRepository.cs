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

    public void Deletar(int id)
    {
        var ong = PegarPorId(id);
        _context.Ongs.Remove(ong);
    }

    public Ong Editar(Ong ongs)
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

    public Ong PegarPorId(int id)
    {
        return _context.Ongs.FirstOrDefault(x => x.Id == id);
    }

    public List<Ong> PegarTodos()
    {
        return _context.Ongs.ToList();
    }
}
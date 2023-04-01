using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class VagaRepository : IVagaRepository
{
    private readonly OngLivesContext _context;

    public VagaRepository(OngLivesContext context)
    {
        _context = context;
    }
    public Vaga Cadastrar(Vaga vaga)
    {
        _context.Vagas.Add(vaga);
        return vaga;
    }

    public void Deletar(int id)
    {
        var vaga = PegarPorId(id);
        _context.Vagas.Remove(vaga);
    }

    public Vaga Editar(Vaga vaga)
    {
        var vagaEdit = PegarPorId(vaga.Id);

        vagaEdit.VoluntarioId = vaga.VoluntarioId;
        vagaEdit.Voluntario = vaga.Voluntario;
        vagaEdit.OngId = vaga.OngId;
        vagaEdit.Ong = vaga.Ong;
        vagaEdit.Tipo = vaga.Tipo;
        vagaEdit.Turno = vaga.Turno;
        vagaEdit.Descricao = vaga.Descricao;      
        vagaEdit.Habilidade = vaga.Habilidade;
        vagaEdit.DataInicio = vaga.DataInicio;
        vagaEdit.DataFim = vaga.DataFim;
        return vagaEdit;

    }

    public Vaga PegarPorId(int id)
    {
        var vaga = _context.Vagas.FirstOrDefault(x => x.Id == id);
        if (vaga == null)
        {
            return new Vaga();
        }
        return vaga;        
    }

    public List<Vaga> PegarTodos()
    {
        return _context.Vagas.ToList();
    }
}
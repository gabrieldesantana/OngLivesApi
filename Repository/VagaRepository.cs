using ONGLIVES.API.Entidades;
using ONGLIVES.API.Persistence.Context;

public class VagaRepository : IVagaRepository
{
    private readonly OngLivesContext _context;

    public VagaRepository(OngLivesContext context)
    {
        _context = context;
    }
    public async Task<Vaga> Cadastrar(Vaga vaga)
    {
        _context.Vagas.Add(vaga);
        return vaga;
    }

    public async Task Deletar(Vaga vaga)
    {
        _context.Vagas.Remove(vaga);
    }


    public async Task<Vaga> Editar(EditVagaModel vaga)
    {
        var vagaEdit = await PegarPorId(vaga.Id);

        //vagaEdit.VoluntarioId = vaga.VoluntarioId;
        // vagaEdit.Voluntario = vaga.Voluntario;
        //vagaEdit.OngId = vaga.OngId;
        // vagaEdit.Ong = vaga.Ong;
        vagaEdit.Tipo = vaga.Tipo;
        vagaEdit.Turno = vaga.Turno;
        vagaEdit.Descricao = vaga.Descricao;      
        vagaEdit.Habilidade = vaga.Habilidade;
        vagaEdit.DataInicio = vaga.DataInicio;
        vagaEdit.DataFim = vaga.DataFim;
        return vagaEdit;

    }

    public async Task<Vaga> PegarPorId(int id)
    {
        return _context.Vagas.FirstOrDefault(x => x.Id == id);
               
    }

    public async Task<List<Vaga>> PegarTodos()
    {
        return _context.Vagas.ToList();
    }
}
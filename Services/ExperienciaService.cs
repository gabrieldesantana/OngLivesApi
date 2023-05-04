using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class ExperienciaService : IExperienciaService
{
    private readonly IExperienciaRepository _repository;
    private readonly IVoluntarioRepository _voluntarioRepository;
    private readonly IOngRepository _ongRepository;
    public ExperienciaService(IExperienciaRepository repository, IVoluntarioRepository voluntarioRepository, IOngRepository ongRepository)
    {
        _repository = repository;
        _voluntarioRepository = voluntarioRepository;
        _ongRepository = ongRepository;
    }

    public async Task<Experiencia> Cadastrar(Experiencia experiencia)
    {
        var experiencias = await _repository.PegarTodos();
        //validacoes
        if (experiencia == null)
            throw new Exception("Experiencia sem informacoes");

        if (experiencias.Exists(x => x.Id == experiencia.Id))
            throw new Exception("ExperienciaId ja existe");

        var voluntario = await _voluntarioRepository.PegarPorNome(experiencia.NomeVoluntario, experiencia.SobrenomeVoluntario);
        var ong = await _ongRepository.PegarPorNome(experiencia.NomeOng);
        
        experiencia.IdOng = ong.Id;
        experiencia.IdVoluntario = voluntario.Id;

        _repository.Cadastrar(experiencia);
        return experiencia;
    }

    public async Task<bool> Deletar(int id)
    {
         var experiencia = await _repository.PegarPorId(id);

        if (experiencia == null)
            return false;
        //return Boolean
        await _repository.Deletar(experiencia);
        return true;
    }

    public async Task<Experiencia> Editar(EditExperienciaModel experiencia)
    {
        var experienciaEdit = await _repository.PegarPorId(experiencia.Id);
        
        if (experienciaEdit == null)
            return null;

        experienciaEdit = await _repository.Editar(experiencia);

        return experienciaEdit;
    }

    public async Task<Experiencia> PegarPorId(int id)
    {
        return await _repository.PegarPorId(id);
    }

    public async Task<List<Experiencia>> PegarTodos()
    {
        return await _repository.PegarTodos();
    }
}
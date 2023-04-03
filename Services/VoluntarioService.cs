using ONGLIVES.API.Entidades;
using ONGLIVESAPI.Interfaces;

public class VoluntarioService : IVoluntarioService
{
    private readonly IVoluntarioRepository _repository;
    public VoluntarioService(IVoluntarioRepository repository)
    {
        _repository = repository;
    }
    public async Task<Voluntario> Cadastrar(Voluntario voluntario)
    {
        var voluntarios = await _repository.PegarTodos();
        //validacoes
        if (voluntario == null)
            throw new Exception("Voluntario sem informacoes");

        if (voluntarios.Exists(x => x.Id == voluntario.Id))
            throw new Exception("VoluntarioId já existe");

        _repository.Cadastrar(voluntario);

        return voluntario;
    }

    public async Task<Voluntario> Editar(EditVoluntarioModel voluntario)
    {
        var voluntarioEdit = await _repository.PegarPorId(voluntario.Id);

        if (voluntarioEdit == null)
            return null;

        voluntarioEdit = await _repository.Editar(voluntario);

        return voluntarioEdit;
    }

    public async Task<List<Voluntario>> PegarTodos()
    {
        return await _repository.PegarTodos();
    }

    public async Task<Voluntario> PegarPorId(int id)
    {   
        var voluntario = await _repository.PegarPorId(id);

        if (voluntario == null) 
            return null;

        return await _repository.PegarPorId(id);
    }

    public async Task<bool> Deletar(int id)
    {
        var voluntario = await _repository.PegarPorId(id);

        if (voluntario == null)
            return false;
            //return Boolean
        await _repository.Deletar(voluntario);
        return true;
    }
}
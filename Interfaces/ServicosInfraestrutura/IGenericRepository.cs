using ONGLIVES.API.Entidades;

namespace ONGLIVES.API.Interfaces.ServicosInfraestrutura
{
    public interface IGenericRepository<T> where T: class
    {
        public List<T> PegarTodos();
        public T Cadastrar(T entity);
        public T PegarPorId(int id);
        public T Editar(T entity);
        public void Deletar(int id);
    }
}

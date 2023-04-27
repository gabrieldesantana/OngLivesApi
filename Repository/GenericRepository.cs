using ONGLIVES.API.Entidades;
using ONGLIVES.API.Interfaces.ServicosInfraestrutura;
using ONGLIVES.API.Persistence.Context;

namespace ONGLIVES.API.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Base
    {
        protected readonly OngLivesContext _context;
        //internal DbSet<T> _dbSet;
        public GenericRepository(OngLivesContext context)
        {
            _context = context;
            //_dbSet = _context.Set<T>();
        }

        public List<T> PegarTodos()
        {
            //return _dbSet.ToList();
            throw new NotImplementedException();
        }
        public T PegarPorId(int id)
        {
            //return _dbSet.FirstOrDefault(x => x.Id == id);
            throw new NotImplementedException();
        }

        public T Cadastrar(T entity)
        {
            try
            {
                //_dbSet.Add(entity);
                //_context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return entity;
        }
        // public T Editar(T entity)
        // {
        //     if (!Exists(entity.Id))
        //         return null;

        //     var result = PegarPorId(entity.Id);
        //     if (result != null)
        //     {
        //         try
        //         {
        //             //_context.Entry(result).CurrentValues.SetValues(entity);
        //             //_context.SaveChanges();
        //         }
        //         catch (Exception)
        //         {

        //             throw;
        //         }
        //     }
        //     return entity;
        // }

        public void Deletar(int id)
        {
            var retorno = PegarPorId(id);

            if (retorno != null) 
            {
                try
                {
                    //_dbSet.Remove(retorno);
                    //_context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            throw new NotImplementedException();
        }

        public T Editar(T entity)
        {
            throw new NotImplementedException();
        }

        // public bool Exists(long id)
        // {
        //     return _dbSet.Any(x => x.Id.Equals(id));
        // }
    }
}

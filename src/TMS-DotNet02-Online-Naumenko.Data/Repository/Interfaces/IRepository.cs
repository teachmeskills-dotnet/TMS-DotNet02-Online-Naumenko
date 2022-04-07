namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        Task AddAsync(T entity);

        void Update(T entity);

        void Delete(int id);

        void DeleteRange(IEnumerable<T> entity);

        Task SaveChangesAsync();
    }
}

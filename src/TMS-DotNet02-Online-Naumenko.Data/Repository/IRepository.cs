namespace TMS_DotNet02_Online_Naumenko.Data.Repository
{
    /// <summary>
    /// Generic repository provide all base needed methods (CRUD)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get all queries.
        /// </summary>
        /// <returns>IQueryable queries.</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Add new entity async.
        /// </summary>
        /// <param name="entity">Entity object</param>
        Task AddAsync(T entity);

        /// <summary>
        /// Add new entities async.
        /// </summary>
        /// <param name="entities">Entity collection.</param>
        Task AddRangeAsync(IEnumerable<T> entities);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity object</param>
        void Update(T entity);

        /// <summary>
        /// Remove entity from database.
        /// </summary>
        /// <param name="entity">Entity object.</param>
        void Delete(T entity);

        /// <summary>
        /// Remove entities from database
        /// </summary>
        /// <param name="entity">Entity object</param>
        void DeleteRange(IEnumerable<T> entity);

        /// <summary>
        /// Persists all updates to the data source async.
        /// </summary>
        Task SaveChangesAsync();
    }
}

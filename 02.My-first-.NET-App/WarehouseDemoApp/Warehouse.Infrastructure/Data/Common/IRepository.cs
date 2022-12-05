using System.Linq.Expressions;

namespace Warehouse.Infrastructure.Data.Common
{
    // Abstraction of repository access methods
    /// <typeparam name="T">Repository type / db table</typeparam>
    public interface IRepository : IDisposable
    {
        // All records in a table
        // <returns>Queryable expression tree</returns>
        IQueryable<T> All<T>() where T : class;

        // All records in a table
        // <returns>Queryable expression tree</returns>
        IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class;

        // The result collection won't be tracked by the context
        // <returns>Expression tree</returns>
        IQueryable<T> AllReadonly<T>() where T : class;

        // The result collection won't be tracked by the context
        // <returns>Expression tree</returns>
        IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class;

        // Gets specific record from database by primary key
        /// <param name="id">record identificator</param>
        // <returns>Single record</returns>
        Task<T> GetByIdAsync<T>(object id) where T : class;

        Task<T> GetByIdsAsync<T>(object[] id) where T : class;

        // Adds entity to the database
        /// <param name="entity">Entity to add</param>
        Task AddAsync<T>(T entity) where T : class;

        // Ads collection of entities to the database
        /// <param name="entities">Enumerable list of entities</param>
        Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class;

        // Updates a record in database
        /// <param name="entity">Entity for record to be updated</param>
        void Update<T>(T entity) where T : class;

        // Updates set of records in the database
        /// <param name="entities">Enumerable collection of entities to be updated</param>
        void UpdateRange<T>(IEnumerable<T> entities) where T : class;

        // Deletes a record from database
        /// <param name="id">Identificator of record to be deleted</param>
        Task DeleteAsync<T>(object id) where T : class;

        // Deletes a record from database
        /// <param name="entity">Entity representing record to be deleted</param>
        void Delete<T>(T entity) where T : class;

        void DeleteRange<T>(IEnumerable<T> entities) where T : class;
        void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class;

        // Detaches given entity from the context
        /// <param name="entity">Entity to be detached</param>
        void Detach<T>(T entity) where T : class;

        // Saves all made changes in trasaction
        // <returns>Error code</returns>
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
using BPT.Test.JDPS.Core.Entities;
using BPT.Test.JDPS.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPT.Test.JDPS.Infraestructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly DbContext _context;

        protected readonly DbSet<T> _entities;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">DB Context</param>
        public BaseRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        /// <summary>
        /// Create a new entity
        /// </summary>
        /// <param name="entity">Entity to create</param>
        /// <returns></returns>
        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        /// <returns></returns>
        public async Task Delete(T entity)
        {
            _entities.Remove(entity);
        }

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns>Return entities</returns>
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        /// <summary>
        /// Get an specific entity
        /// </summary>
        /// <param name="id">Id of entity</param>
        /// <returns>Return an entity</returns>
        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity">Entity to update</param>
        public void Update(T entity)
        {
            _entities.Update(entity);
        }
    }
}

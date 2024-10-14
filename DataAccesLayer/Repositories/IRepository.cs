

using DataAccesLayer.Entities;
using DataAccesLayer.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Repositories
{
/// <summary>
/// an interface that will handle queries on db 
/// </summary>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// method to get all entities of type T async
        /// <parameter>T</parameter> reprezent the entity that will be queried 
        /// </summary>
       public Task<List<T>> getAllAsync();
        /// <summary>
        /// method to get all entities of type T 
        /// <parameter>T</parameter> reprezent the entity that will be queried 
        /// </summary>
       public List<T> getAll();
        /// <summary>
        /// method to get an entity by an id async
        /// </summary>
        /// <param name="id">id of an entity</param>
        /// <returns>returns the entity if it exists in db , if not returns null</returns>
       public Task<T?> getByIdAsync(int id);
        /// <summary>
        /// method to get an entity by an id
        /// </summary>
        /// <param name="id">id of an entity</param>
        /// <returns>returns the entity if it exists in db , if not returns null</returns>
        public T? getById(int id);
        /// <summary>
        /// delete an entity 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool delete(int id);
        /// <summary>
        /// delete and entity async 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> deleteAsync(int id);
        /// <summary>
        /// update an entity 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity);
        /// <summary>
        /// update entity async
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<bool> UpdateAsync(T entity);
        /// <summary>
        /// create an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Create(T entity);
        /// <summary>
        /// create async method creates an entity async 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<bool> CreateAsync(T entity);

        public  Task<List<T>> GetAllWithQuery(Func<IQueryable<T>, IQueryable<T>> query);
        /// <summary>
        /// returns all entities of type T in a group 
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public Task<List<T>> GetByGroupId(int groupId);

    }
}

using DataAccesLayer;
using DataAccesLayer.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccesLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataBaseContext _context;

        public Repository(DataBaseContext  context)
        {
            _context = context;
        }

        public bool Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public bool delete(int id)
        {
            var entityToDelete = _context.Set<T>().ToList().Find(e => e.Id == id);
            if (entityToDelete == null)
            {
                return false;
            }
            else
            {
                _context.Remove(entityToDelete);
                _context.SaveChanges();
                return true;
            }
        }

        public async Task<bool> deleteAsync(int id)
        {
            var entityToDelete = _context.Set<T>().ToList().Find(e => e.Id == id);
            if (entityToDelete == null)
            {
                return false;
            }
            else
            {
                _context.Remove(entityToDelete);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public List<T> getAll()
        {
            var entities = _context.Set<T>().ToList();
            return entities;
        }

        public async Task<List<T>> getAllAsync()
        {
            var entities = await _context.Set<T>().ToListAsync();
            return entities;
        }
        //public async Task<List<T>> GetUsersByGroupId(string groupId)
        //{
        //    return await _context.Set<GroupT>()
        //                         .Where(gu => gu.GroupId.Equals(groupId))
        //                         .Select(gu => gu.T)
        //                         .ToListAsync();
        //}
        public async Task<List<T>> GetAllWithQuery(Func<IQueryable<T>, IQueryable<T>> query)
        {
            // Aplicăm query-ul primit asupra setului de date din context
            IQueryable<T> result = query(_context.Set<T>());

            // Executăm query-ul și returnăm lista rezultată
            return await result.ToListAsync();
        }

        public T? getById(int id)
        {
            var entity = _context.Set<T>().ToList().Find(e => e.Id == id);
            if (entity == null)
            {
                return null;
            }
            return entity;
        }

        public async Task<T?> getByIdAsync(int id)
        {
            var entity = _context.Set<T>().ToList().Find(e => e.Id == id);
            if (entity == null)
            {
                return null;
            }
            return entity;
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        Task<List<T>> IRepository<T>.GetByGroupId(int groupId)
        {
            throw new NotImplementedException();
        }
    }
}

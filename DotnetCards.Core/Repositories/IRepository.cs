using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SimpleDotnet.Core.Repositories
{
	interface IRepository<TEntity> where TEntity : class
	{
		Task<TEntity> GetByIdAsync(int id);
		Task<IEnumerable<TEntity>> GetAllAsync();
		Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
		Task AddAsync(TEntity entity);
		Task AddRangeAsync(IEnumerable<TEntity> entities);
		void Remove(TEntity entity);
		Task RemoveRangeAsync(IEnumerable<TEntity> entities);
		TEntity Update(TEntity entity);
	}
}

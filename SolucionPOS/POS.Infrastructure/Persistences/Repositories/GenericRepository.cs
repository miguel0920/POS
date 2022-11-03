using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Helpers;
using POS.Infrastructure.Persistences.Interfaces;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected IQueryable<TDTO> Ordering<TDTO, TKEY>(PaginationRequest request, IQueryable<TDTO> queryable,
            Expression<Func<TDTO, TKEY>> keySelector, bool pagination = false) where TDTO : class
        {
            IQueryable<TDTO> queryDto = !request.OrderAsc ? queryable.OrderBy<TDTO>(request.Sort)
                : queryable.OrderByDescending<TDTO, TKEY>(keySelector);
            if (pagination) queryDto = queryDto.Paginate(request);
            return queryDto;
        }
    }
}
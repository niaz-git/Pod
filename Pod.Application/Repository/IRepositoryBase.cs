using Pod.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Pod.Application.Repository
{
    public interface IRepositoryBase<T>
    {
        CommonResponse FindAll();
        CommonResponse GetData();

        CommonResponse FindByCondition(Expression<Func<T, bool>> expression);
        CommonResponse Create(T entity);
        CommonResponse Update(T entity);
        CommonResponse Delete(T entity);
    }
}

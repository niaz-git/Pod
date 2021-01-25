using Microsoft.EntityFrameworkCore;
using Pod.Core.Infrastructure;
using Pod.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Pod.Application.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PodContext RepositoryContext { get; set; }
        public RepositoryBase(PodContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
        public CommonResponse FindAll()
        {
            try { 
            return  CommonResponse.Ok(this.RepositoryContext.Set<T>().AsNoTracking());
        }
            catch (Exception ex)
            {
                return CommonResponse.Error();
            }
}

     
        public CommonResponse FindByCondition(Expression<Func<T, bool>> expression)
        {
            try
            {
                return CommonResponse.Ok( this.RepositoryContext.Set<T>().Where(expression).AsNoTracking());

            }
            catch (Exception ex)
            {
                return CommonResponse.Error();
            }
        }
        public CommonResponse Create(T entity)
        {
            try
            {
                this.RepositoryContext.Set<T>().Add(entity);
                return CommonResponse.Ok(entity);
            }catch(Exception ex)
            {
                return CommonResponse.Error();
            }
        }
        public CommonResponse Update(T entity)
        {
            try { 
            this.RepositoryContext.Set<T>().Update(entity);
            return CommonResponse.Ok(entity);
        }catch(Exception ex)
            {
                return CommonResponse.Error();
            }
}
        public CommonResponse Delete(T entity)
        {
            try { 
            this.RepositoryContext.Set<T>().Remove(entity);
            return CommonResponse.Ok();
        }catch(Exception ex)
            {
                return CommonResponse.Error();
            }
        }

        public CommonResponse GetData()
        {
            try
            {
                return CommonResponse.Ok(this.RepositoryContext.PaymentRequest.Include(x => x.PaymentState).ToList());
            }
            catch (Exception ex)
            {
                return CommonResponse.Error();
            }
        }
    }
}

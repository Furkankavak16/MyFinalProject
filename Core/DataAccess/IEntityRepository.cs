
using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic consterint yapcaz yani genericler kısıtlama operasyonları ki herkes o genericleri kullanmasın
    //class:referans tip anlamında buradaki class
   public interface IEntityRepository<T>where T:class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       



    }
}

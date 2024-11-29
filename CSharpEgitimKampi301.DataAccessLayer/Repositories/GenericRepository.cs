using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class // Burada IGenericDal tazınca altını çizdi ampülden implement deyince aşağıdaki kodları yazdı
    {
        CampContext context = new CampContext();
        private readonly DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
           var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted; // Ekleme silme güncelleme için kullanabileceğim EF kodlarıdır
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntry = context.Entry<T>(entity);
            addedEntry.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntry = context.Entry<T>(entity);
            updatedEntry.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

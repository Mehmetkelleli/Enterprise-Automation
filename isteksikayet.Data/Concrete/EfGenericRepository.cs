using isteksikayet.Data.Abstract;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isteksikayet.Data.Concrete
{
    public class EfGenericRepository<T, TContext> : IGenericRepository<T>
        where T:class
        where TContext:IdentityDbContext ,new()
    {
        public void Create(T t)
        {
            using (var db = new TContext())
            {
                db.Set<T>().Add(t);

                db.SaveChanges();
            }
        }

        public void Delete(T t)
        {
            using (var db = new TContext())
            {
                db.Set<T>().Remove(t);
                db.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var db = new TContext())
            {
                return db.Set<T>().ToList();
            }
        }

        public T GetById(int Id)
        {
            using (var db = new TContext())
            {
                return db.Set<T>().Find(Id);
            }
        }

        public void Update(T t)
        {
            using (var db = new TContext())
            {
                db.Entry(t).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

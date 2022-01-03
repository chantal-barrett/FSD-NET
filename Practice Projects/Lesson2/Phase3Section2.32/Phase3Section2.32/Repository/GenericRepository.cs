using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Phase3Section2._32.Models;

namespace Phase3Section2._32.Repository
{
    public class GenericRepository<t> : IGenericRepository<t> where T : class
    {
        private GenericDBContext db = null;
        private DbSet<t> table = null;
        public GenericRepository()
        {
            this.db = new GenericDBContext();
            table = db.Set<t>();
        }
        public GenericRepository(GenericDBContext db)
        {
            this.db = db;
            table = db.Set<t>();
        }
        public IEnumerable<t> SelectAll()
        {
            return table.ToList();
        }
        public T SelectByID(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}

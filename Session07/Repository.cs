using Session07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07
{
    public class Repository
    {
        protected NorthWindContext ctx { get; set; }
        public Repository()
        {
            ctx = new NorthWindContext();
        }

        //CRUD

        public T Create<T>(T model) where T : class
        {
            //ctx.Set<T>().Add(model);
            ctx.Add(model);
            ctx.SaveChanges();
            return model;
        }


        public T Update<T>(T model) where T : class
        {
            ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
            return model;
        }

        public T Find<T>(int id) where T : class
        {
            //ctx.Set<T>().FirstOrDefault(x => x.id);
            return ctx.Set<T>().Find(id);
        }

        public void Delete<T>(T model) where T : class
        {
            //ctx.Set<T>().Remove(model);
            ctx.Remove(model);
            ctx.SaveChanges();
        }

        public void Delete<T>(int id) where T : class
        {
            var model = Find<T>(id);
            ctx.Remove(model);
            ctx.SaveChanges();
        }

        public IQueryable<T> AsQueryable<T>() where T : class
        {
            return ctx.Set<T>().AsQueryable();
        }
    }
}

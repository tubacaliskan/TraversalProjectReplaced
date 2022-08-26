using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using DataAccessLayer.Concrete;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        // burda bunu yapma amacımızı pek anlayamadım 10. video
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);          
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
        }
    }
}

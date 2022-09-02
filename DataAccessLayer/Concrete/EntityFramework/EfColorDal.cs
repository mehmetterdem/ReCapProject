using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(CarColor entity)
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CarColor entity)
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<CarColor> GetAll(Expression<Func<CarColor, bool>> filter = null)
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
                return filter == null ? context.Set<CarColor>().ToList() : context.Set<CarColor>().Where(filter).ToList();
            }
        }

        public CarColor Get(Expression<Func<CarColor, bool>> filter)
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
               return  context.Set<CarColor>().Where(filter).FirstOrDefault();
            }
        }

        public void Update(CarColor entity)
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }


}


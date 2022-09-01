using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=1250000,Description="Mercedes"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2022,DailyPrice=1250000,Description="BMW" },
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear=2019,DailyPrice=1250000,Description="Alfa Romeo" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteToCar = _cars.Where(x => x.Id == car.Id).FirstOrDefault() ;
            _cars.Remove(DeleteToCar);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(x => x.Id == id).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car UpdateToCar = _cars.Where(x => x.Id == car.Id).FirstOrDefault();
            UpdateToCar.Id = car.Id;
            UpdateToCar.BrandId = car.Id;
            UpdateToCar.ColorId = car.ColorId;
            UpdateToCar.DailyPrice = car.DailyPrice;
            UpdateToCar.Description = car.Description;
        }
    }
}

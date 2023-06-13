using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId= 1, DailyPrice=1500, ModelYear = 2022, Description= "Tesla"},
                new Car {Id=2, BrandId=2, ColorId= 1, DailyPrice=56000, ModelYear = 2019, Description= "Bugatti"},
                new Car {Id=3, BrandId=3, ColorId= 1, DailyPrice=900, ModelYear = 2018, Description= "Audi"},
                new Car {Id=4, BrandId=4, ColorId= 1, DailyPrice=680, ModelYear = 2019, Description= "Fiat"},
            };
        }
        public void Add(Car car)
        {
            Console.WriteLine("InMemory çalıştı.");
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _car.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id=car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;    
        }
    }
}

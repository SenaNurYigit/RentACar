using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal iCarDal)
        {
            _iCarDal= iCarDal;
        }
       
        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _iCarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _iCarDal.GetAll(p=>p.ColorId==id);
        }
        public void Add(Car car)
        {
            if(car.Description.Length>=2 && car.DailyPrice>0)
            {
                _iCarDal.Add(car);
            }
            else { Console.WriteLine("Araç ekleme şartı sağlanamadı."); }
        }
    }
}

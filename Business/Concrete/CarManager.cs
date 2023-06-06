﻿using Business.Abstract;
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
        public void Add(Car car)
        {
            //Console.WriteLine( car.Description + "Eklendi." );
            _iCarDal.Add(car);

        }

        public Car GetById(int id)
        {
           return _iCarDal.GetById(id);
        }

        public void Delete(Car car)
        {
            _iCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public void Update(Car car)
        {
            _iCarDal.Update(car);
        }
    }
}

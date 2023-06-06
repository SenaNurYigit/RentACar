
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EFCarDal());

Car car = new Car();
car.Id = 1;
car.Description = "Reno";
car.ModelYear = 12;
car.BrandId = 2;
car.ColorId = 5;
car.DailyPrice = 15;

carManager.Add(car);

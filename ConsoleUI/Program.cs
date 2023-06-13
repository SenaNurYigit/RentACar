
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EFCarDal());

Car car = new Car();
car.Id = 5;
car.Description = "Renol";
car.ModelYear = 12;
car.BrandId = 2;
car.ColorId = 5;
car.DailyPrice = 15;

carManager.Add(car);

Car car2 = new Car();
car2.Description = "B";
car2.ModelYear = 13;
car2.BrandId = 5;
car2.ColorId = 8;
car2.DailyPrice = 16;
carManager.Add(car2);

using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{VehicleId=1,BrandId=1,ColorId=1,MordelYear=1998,DailyPrice=190,Description="BMW"},
                 new Car{VehicleId=2,BrandId=2,ColorId=5,MordelYear=2005,DailyPrice=300,Description="MERCEDES"},
                  new Car{VehicleId=3,BrandId=3,ColorId=3,MordelYear=1992,DailyPrice=70,Description="TOFAŞ"},
                 new Car{VehicleId=4,BrandId=4,ColorId=4,MordelYear=2001,DailyPrice=140,Description="FİAT"}

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.VehicleId == car.VehicleId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.VehicleId == car.VehicleId);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.MordelYear = car.MordelYear;

        }
    }
}

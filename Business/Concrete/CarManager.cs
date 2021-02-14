using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {

            
                if (car.DailyPrice > 0 && car.Description.Length > 2)
                {
                    _carDal.Add(car);
                    Console.WriteLine(car.Description + " added in the list");

                }
                else
                {
                    Console.WriteLine("Could not be added");
                }


            





        }

        public List<Car> GetAll()
        { //here are the rules
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }
    }
}

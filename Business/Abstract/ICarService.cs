using Core.Ultities;
using Core.Ultities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        //List<Car> GetAll();
       IDataResult <List<Car>> GetCarsByBrandId(int brandId);
       IDataResult <List<Car>> GetCarsByColorId(int colorId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IDataResult <List<CarDetailDto>> GetCarDetails();


    }
}

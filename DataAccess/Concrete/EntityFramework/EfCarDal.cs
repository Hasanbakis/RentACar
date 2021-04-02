using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, SouthwindContext>, ICarDal
    {


        public CarDetailDto GetCarDetail(int carId)
        {
            using (SouthwindContext context = new SouthwindContext())
            {
                var result = from c in context.Cars.Where(c=>c.CarId == carId)
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             join d in context.Brands
                             on c.BrandId equals d.BrandId
                             join carImg in context.CarImages
                              on c.CarId equals carImg.CarId
                             from r in context.Rentals where r.CarId == c.CarId
                             select new CarDetailDto
                             {
                                 BrandName = d.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 ImagePath = carImg.ImagePath,
                                 Status = r.ReturnDate ==null?false:true
                             };

                return result.SingleOrDefault();
            }
        }
        public List<CarDetailDto> GetAllCarDetails(Expression<Func<Car,bool>>filter=null)
        {
            using (SouthwindContext context = new SouthwindContext())
            {
                var result = from c in filter==null ? context.Cars :context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             join carImg in context.CarImages 
                             on c.CarId equals carImg.CarId
                             select new CarDetailDto
                             {
                                 CarId=c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 Description =c.Description,
                                 ImagePath = carImg.ImagePath
                               
                             };
                return result.ToList();
            }
        }

       
    }
}

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
                var result = from c in context.Cars.Where(c => c.CarId == carId)
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             join d in context.Brands
                             on c.BrandId equals d.BrandId
                             join r in context.Rentals 
                             on c.CarId equals r.CarId into gj
                             from subCar in gj.DefaultIfEmpty()
                             //join carImg in context.CarImages
                             // on c.CarId equals carImg.CarId
                             //from r in context.Rentals where r.CarId == c.CarId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ColorId = c.ColorId,
                                 BrandId = c.BrandId,
                                 BrandName = d.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 CarName = c.CarName,
                                 FindexPoint = c.FindexPoint,
                                 Images = context.CarImages.Where(ci => ci.CarId == c.CarId).Select(i=>i.ImagePath).ToList(),
                                 //(from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).ToList(),
                                 Status = DateTime.Now > subCar.ReturnDate
                             };
                return result.FirstOrDefault();
            }
        }
        public List<CarDetailDto> GetAllCarDetails(Expression<Func<Car,bool>>filter=null)
        {
            using (SouthwindContext context = new SouthwindContext())
            {
                var result = from c in filter==null?context.Cars :context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             
                             select new CarDetailDto
                             {
                                 CarId=c.CarId,
                                 ColorId=c.ColorId,
                                 BrandId= c.BrandId,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 Description =c.Description,
                                 FindexPoint =c.FindexPoint,
                                 Images =
                                (from i in context.CarImages where i.CarId == c.CarId select i.ImagePath).ToList(),

                             };
                return result.ToList();
            }
        }

       
    }
}

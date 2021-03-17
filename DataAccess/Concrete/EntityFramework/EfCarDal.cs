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

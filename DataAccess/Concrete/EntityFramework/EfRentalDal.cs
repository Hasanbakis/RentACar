using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, SouthwindContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (SouthwindContext context = new SouthwindContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cs in context.Customers
                             on r.CustomerId equals cs.CustomerId
                             join u in context.Users
                             on cs.UserId equals u.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 FirstName =  u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = b.BrandName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 Description =c.Description

                             };


                return result.ToList();

            }
        }
    }
}

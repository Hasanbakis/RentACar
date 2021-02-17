using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //BrandTest2();
            
            //Data Transformation Object
            DTO();


        }

        private static void DTO()
        {   
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if(result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} : {1} : {2} : {3}", car.BrandName, car.CarName, car.ColorName, car.DailyPrice);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
            
               

            
        }

       

        private static void BrandTest2()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var brand = brandManager.GetById(3);
            Console.WriteLine(brand);
        }



    }
}

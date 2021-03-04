using Business.Concrete;
using Core.Entites.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //CarManager carManager = new CarManager(new EfCarDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //UserManager userManager = new UserManager(new EfUserDal());

            //BrandTest2();
            //Data Transformation Object
           // AddTest(rentalManager);
            //GetCarDetailDto(carManager);
            //UserAdd(userManager);



            //var result = brandManager.Delete(new Brand { ID = 4 });
            //Console.WriteLine(result.Message);


        }
        private static void AddTest(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental {
                RentalId = 3,
                CarId = 1,
                CustomerId = 1
            });
            Console.WriteLine(result.Message);
        }
        private static void UserAdd(UserManager userManager)
        {
            var result = userManager.Add( new User {
            
                FirstName = "Davut",
                LastName = "Gökalp",
                Email = "ahmetylmz01@gmail.com",
                
            });
            Console.WriteLine(result.Message);
        }

        private static void GetCarDetailDto(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + "\t" + car.CarName + "\t" + car.ColorName + "\t" + car.DailyPrice);
            }
        }



    }
   




       

     


}



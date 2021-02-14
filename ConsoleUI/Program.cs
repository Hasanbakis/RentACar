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

            CarManager carManager = new CarManager(new EfCarDal());
           

            Console.WriteLine("-------------------------");
           
            
                Car car = new Car()
                {

                    BrandId = 1,
                    ColorId = 5,
                    ModelYear =2010,
                    DailyPrice = 500,
                    Description = "Comfortable"

                };
                carManager.Add(car);

            



            Console.WriteLine("-------------------------");

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description);
                Console.WriteLine("******");

            }
        


        }

    }
}

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
            //CarTest();

            //CarImageManager carImageManager = new CarImageManager(new EfCarImageDal());

            //var result = carImageManager.GetAll();

            //foreach (var carImage in result.Data)
            //{
            //    Console.WriteLine(carImage.CarId);
            //}


        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/ " + car.BrandName + " / " + car.ColorName + "/" + car.DailyPrice);
                }
            }
            
        }
    }
}

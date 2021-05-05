using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var result = from car in context.cars
                             join brand in context.brands
                             on car.BrandId equals brand.BrandId
                             join color in context.colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 ColorName=color.ColorName,
                                 CarName=car.CarName,
                                 DailyPrice = car.DailyPrice,
                                 Descriptions = car.Descriptions
                             };
                return result.ToList();
                    
            }

        }
    }
}

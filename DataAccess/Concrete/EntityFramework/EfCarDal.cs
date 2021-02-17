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
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {

                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join r in context.Color
                             on c.ColorId equals r.ColorId

                             select new CarDetailsDto
                             {
                                 Id = c.Id,
                                 CarName = c.CarName,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = r.ColorId,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Descriptions


                             };

                return result.ToList();
            }
        }
    }
}
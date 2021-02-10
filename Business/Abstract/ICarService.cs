using Business.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int Id);
        List<Car> GetCarsByColorId(int ColorId);
        List<Car> GetCarsByBrandId(int BrandId);
        List<Car> GetByDailyPrice(decimal max, decimal min);
        List<Car> GetByModelYear(string year);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{ Id=1,BrandId=1,ColorId=4,DailyPrice=140,ModelYear=2020,Descriptions="Ford" },
                new Car{ Id=2,BrandId=2,ColorId=6,DailyPrice=300,ModelYear=1903,Descriptions="Nissan" },
                new Car{ Id=3,BrandId=3,ColorId=4,DailyPrice=150,ModelYear=1997,Descriptions="Jeep" },
                new Car{ Id=4,BrandId=4,ColorId=6,DailyPrice=100,ModelYear=1998,Descriptions="Kia" },
                new Car{ Id=5,BrandId=5,ColorId=2,DailyPrice=250,ModelYear=2021,Descriptions="MiniCooper" }

            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car _deleteToCar = _car.FirstOrDefault(c => c.Id == car.Id);
            _car.Remove(_deleteToCar);
        }

        public Car Get(Expression<Func<Car,bool>> filter)
        {
            return null;
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return null;
        }

        public List<CarDetailsDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car _updateToCar = _car.FirstOrDefault(c => c.Id == car.Id);
            _updateToCar.BrandId = car.BrandId;
            _updateToCar.ColorId = car.ColorId;
            _updateToCar.DailyPrice = car.DailyPrice;
            _updateToCar.ModelYear = car.ModelYear;
            _updateToCar.Descriptions= car.Descriptions;
        }
    }
}
﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)

        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());



            // CarDetailTest(carManager);
            // ColorManagerTest(colorManager);
            // BrandManagerTest(brandManager);
            CarManagerTest(carManager);
            var result = carManager.Delete(new Car { Id = 1903 });
            Console.WriteLine(result.Message);
        }

        private static void CarDetailTeest(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success)
            {

                foreach (var item in result.Data)

                {
                    Console.WriteLine(item.Id + "  " + item.CarName + "  " + item.ModelYear + "  " + item.Descriptions);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorManagerTest(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            if (result.Success)
            {

                foreach (var item in result.Data)

                {
                    Console.WriteLine(item.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void BrandManagerTest(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success)
            {

                foreach (var item in result.Data)

                {
                    Console.WriteLine(item.BrandName);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CarManagerTest(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success)
            {

                foreach (var car in result.Data)

                {
                    Console.WriteLine(car.ModelYear + "//" + car.Id);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
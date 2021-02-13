using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandManagerTest();
            //CarManagerTest();
            //UserManagerTest();

            RentalManager rentalsManager = new RentalManager(new EfRentalDal());
            var rentalsAdd = rentalsManager.Add(new Rentals { CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Today });
            Console.WriteLine(rentalsAdd.Message);

        }

        private static void UserManagerTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var user = userManager.Add(new Users { FirstName = "SEVDA", LastName = "YÜCEL", Email = "svdycl2858@gmail.com", Password = "1903" });
            Console.WriteLine(user.Message);
            foreach (var users in userManager.GetAll().Data)
            {
                Console.WriteLine(users.FirstName + " " + users.LastName);
            }
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 1, BrandName = "Kia" });
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 3, ColorId = 6, DailyPrice = 0, ModelYear = 1997 });


            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Descriptions);
            }


            Console.WriteLine("GetCarsByBrandId");

            foreach (var car in carManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Descriptions);
            }

            Console.WriteLine("GetCarsByColorId");

            foreach (var car in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine(car.ColorId + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Descriptions);

            }
        }
    }

}
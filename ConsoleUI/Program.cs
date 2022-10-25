using BusinessLayer.Concrete;
using CoreLayer.Entities.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;
using EntityLayer.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserAdd();

            //CustomerAdded(1, "Ersa");
            //CustomerAdded(1, "Aras");
            //CustomerAdded(1, "Opet");

            //RentalAdd();


            //CarAddTest();
            //BrandTest();
            //ColorTest();

        }

        private static void RentalAdd(int carId,int customerId,DateTime rentDate,DateTime returnDate)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = carId, CustomerId = customerId, RentDate = rentDate, ReturnDate = returnDate });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Mehmet", LastName = "Erdem" });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAdded(int userId, string companyName)
        {
            CustomerManager customer = new CustomerManager(new EfCustomerDal());
            var result = customer.Add(new Customer { UserId = userId, CompanyName = companyName });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerDelete(int customerId)
        {
            CustomerManager customer = new CustomerManager(new EfCustomerDal());
            var result = customer.GetById(customerId).Data;
            var Test = customer.Delete(result);
            if (Test.Success)
            {
                Console.WriteLine(Test.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new CarColor { ColorName = "Lacivert" });
            var result = colorManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Renault" });
            var result = brandManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.BrandName);
            }
            brandManager.Delete(new Brand { Id = 4, BrandName = "Toyota" });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();


            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.BrandName + "-" + item.ColorName + "-" + item.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
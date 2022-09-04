using BusinessLayer.Concrete;
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



            CarAddTest();
            //BrandTest();
            //ColorTest();

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
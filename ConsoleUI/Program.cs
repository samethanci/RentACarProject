using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetCarsByBrandId(3);
            carManager.Add(new Car { BrandID = 2, ColorId = 1, ModelYear = "2022", DailyPrice = 1500, Description = "2022 Model"});
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car);
            }
        }
    }
}

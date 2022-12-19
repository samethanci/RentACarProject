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
            carManager.Add(new Car { ColorId = 2, DailyPrice = 1591.05M, Description = "Mercedes C Serisi", ModelYear = "2019" });
            carManager.Add(new Car { ColorId = 3, DailyPrice = 1647.8M, Description = "Volvo XC40", ModelYear = "2020" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car);
            }
        }
    }
}

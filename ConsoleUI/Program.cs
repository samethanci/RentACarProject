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
            carManager.Add(new Car { ColorId = 1, DailyPrice = 1591.05M, Description = "Mercedes G kasa", ModelYear = "2021" });
            carManager.Add(new Car { ColorId = 4, DailyPrice = 1647.8M, Description = "Volvo XC90", ModelYear = "2022" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car);
            }
        }
    }
}

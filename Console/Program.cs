using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine("Araba bilgileri");
                Console.WriteLine("Araba ID: " + car.CarId + " Marka ID: " + car.BrandId + " Boya ID: " + car.ColorId + " Üretim Yılı: " + car.ModelYear + " Günlük Kiralama Ücreti: " + car.DailyPrice + " Araba Türü: " + car.Description);
            }
        }
    }
}

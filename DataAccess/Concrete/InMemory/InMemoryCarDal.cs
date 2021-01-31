using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDAL
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    CarId=1,
                    BrandId=1,
                    ColorId=1,
                    DailyPrice=800,
                    ModelYear=2018,
                    Description="Super"
                },
                new Car
                {
                    CarId=2,
                    BrandId=1,
                    ColorId=3,
                    DailyPrice=500,
                    ModelYear=2015,
                    Description="Suport"
                },
                new Car
                {
                    CarId=3,
                    BrandId=2,
                    ColorId=2,
                    DailyPrice=400,
                    ModelYear=2014,
                    Description="Sedan"
                },
                new Car
                {
                    CarId=4,
                    BrandId=4,
                    ColorId=3,
                    DailyPrice=2100,
                    ModelYear=2021,
                    Description="SUV"
                },
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(Car => Car.CarId == Car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(Car => Car.CarId==CarId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(Car => Car.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;
        }
    }
}

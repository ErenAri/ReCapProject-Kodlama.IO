using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL _carDAL;

        public CarManager(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }

        public List<Car> GetAll()
        {
            return _carDAL.GetAll();
        }
    }
}

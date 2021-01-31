using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDAL
    {
        List<Car> GetAll();
        List<Car> GetById(int CarId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}

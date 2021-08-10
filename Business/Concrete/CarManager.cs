using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager
    {
        ICarDal _ICarDal;

        public CarManager(ICarDal iCarDal)
        {
            _ICarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
            return _ICarDal.GetAll();
        }
    }
}

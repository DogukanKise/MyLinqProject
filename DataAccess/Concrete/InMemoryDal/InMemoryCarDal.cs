using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
   public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=5,DailyPrice=10,ModelId=10,Description="BMW"},
                new Car{CarId=2,BrandId=2,ColorId=3,DailyPrice=15,ModelId=11,Description="AUDI"},
                new Car{CarId=3,BrandId=3,ColorId=1,DailyPrice=100,ModelId=1,Description="Jaguar"},
                new Car{CarId=4,BrandId=5,ColorId=1,DailyPrice=4,ModelId=9,Description="Wolkswagen"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(p => p.CarId == CarId).ToList();
        }



        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelId = car.ModelId;
            carToUpdate.Description = car.Description;


        }
    }
}

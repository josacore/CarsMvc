using CarsMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public class CarService : ICarService
    {
        private readonly IContext _context;
        private readonly ICarRepository _cars;

        public CarService(IContext context)
        {
            _context = context;
            _cars = context.Cars;
        }

        public IEnumerable<Models.Car> All()
        {
            return _cars.All().ToArray();
        }
    }
}
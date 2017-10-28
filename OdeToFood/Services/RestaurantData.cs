using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IResturantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IResturantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{Id=1,name="Hotel1"},
                new Restaurant{Id=2,name="Hotel2"},
                new Restaurant{Id=3,name="Hotel3"}

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

    }
}

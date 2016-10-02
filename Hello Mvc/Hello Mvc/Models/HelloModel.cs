using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hello_Mvc.Models
{
    public class HelloModel
    {
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>
            {
                new Car {Id = 1, Make = "Ford", Model= "Flex" },
                new Car {Id = 2, Make = "Dodge", Model= "Ram 1500" },
                new Car {Id = 3, Make = "Pontiac", Model= "G8" }
                
            };
            return cars;
        }

    }


    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

}
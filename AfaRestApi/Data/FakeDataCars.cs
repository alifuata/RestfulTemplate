using AfaRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfaRestApi.Data
{
    /// <summary>
    /// Data for car controllers
    /// </summary>
    public class FakeDataCars
    {
        private static IList<Car> AllCars;
        /// <summary>
        /// Get All Cars
        /// </summary>
        /// <returns>List of All Cars</returns>
        public static IList<Car> GetAllCars()
        {
            if (AllCars == null)
            {
                AllCars = new List<Car>()
               {
                   new Car(){ID=1, Make="Honda", Model="Civic", Year=2021, Price=36000},
                   new Car(){ID=2, Make="Mercedes", Model="CLA-200", Year=2021, Price=56000},
                   new Car(){ID=3, Make="Fiat", Model="Egea", Year=2021, Price=9000},
                   new Car(){ID=4, Make="Peugeot", Model="3008", Year=2021, Price=10500}
               };
            }
            return AllCars;
        }
        /// <summary>
        /// Get spesific car From DB
        /// </summary>
        /// <param name="id">DB ID of Car</param>
        /// <returns>Car</returns>
        public static Car GetCar(int id)
        {
            var car = (from x in AllCars where x.ID == id select x).ToArray();
            if (car.Length > 0) return car[0];
            else return null;
        }
        /// <summary>
        /// inserts car 
        /// </summary>
        /// <param name="car"></param>
        /// <returns>Inserted car</returns>
        public static Car InsertCar(Car car)
        {
            int Id = AllCars.Count+1;
            car.ID = Id;
            AllCars.Add(car);
            return car;
        }
    }
}

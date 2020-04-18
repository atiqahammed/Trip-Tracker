using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTicker.BackService.Models
{
    public class Repository
    {
        public List<Trip> Trips = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Name = "MVP Summit",
                StartDate = new DateTime(2018, 3, 5),
                EndDate = new DateTime(2018, 3, 8)
            },
            new Trip
            {
                Id = 2,
                Name = "Home Vacation For Winter",
                StartDate = new DateTime(2019, 12, 19),
                EndDate = new DateTime(2019, 12, 28)
            },
            new Trip
            {
                Id = 3,
                Name = "Cox'x Bazar University Tour",
                StartDate = new DateTime(2020, 3, 10),
                EndDate = new DateTime(2018, 3, 17)
            }
        };

        public List<Trip> GetTrips()
        {
            return Trips;
        }

        public void Add(Trip trip)
        {
            Trips.Add(trip);
        }

        public void Update(Trip tripToUpdate)
        {
            Trips.Remove(Trips.First(t => t.Id == tripToUpdate.Id));
            Trips.Add(tripToUpdate);
        }
        
        public void Remove(int id)
        {
            Trips.Remove(Trips.First(t => t.Id == id));
        }
    }
}

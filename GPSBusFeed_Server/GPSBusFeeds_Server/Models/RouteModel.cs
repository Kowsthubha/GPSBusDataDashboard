using System;
using System.Collections.Generic;

namespace GPSBusFeeds_Server.Models
{
    public class RouteModel
    {
        public string RouteNumber { get; set; }
        public List<BusDetails> Buses { get; set; }

        public RouteModel()
        {
            Buses = new List<BusDetails>();
        }
    }


    public class BusDetails
    {
        public DateTime ETA { get; set; }
        public string BusNumber { get; set; }

        public static DateTime GetETA()
        {
            Random rand = new Random();
            //Note that Random.Next(int, int) is inclusive lower bound, exclusive upper bound
            DateTime myDateTime = new DateTime(2012, 11, 27,
                rand.Next(7, 11), rand.Next(0, 60), 0);
            return myDateTime;
        }
    }

}

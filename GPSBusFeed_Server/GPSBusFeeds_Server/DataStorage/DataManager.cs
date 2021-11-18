using GPSBusFeeds_Server.Models;
using System;
using System.Collections.Generic;

namespace GPSBusFeeds_Server.DataStorage
{
    public static class DataManager
    {
        public static List<RouteModel> GetData()
        {
            var r = new Random();
            return new List<RouteModel>()
            {
                new RouteModel { RouteNumber = "Route-201", 
                    Buses = new List<BusDetails>{
                        new BusDetails(){ BusNumber="KA04-BA2011", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2012", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2013", ETA = BusDetails.GetETA()}
                    } },
                new RouteModel { RouteNumber = "Route-202" ,
                    Buses = new List<BusDetails>{
                        new BusDetails(){ BusNumber="KA04-BA2021", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2022", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2023", ETA = BusDetails.GetETA()}
                    } },
                new RouteModel { RouteNumber = "Route-203" ,
                    Buses = new List<BusDetails>{
                        new BusDetails(){ BusNumber="KA04-BA2031", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2032", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2033", ETA = BusDetails.GetETA()}
                    } },
                new RouteModel { RouteNumber = "Route-204" ,
                    Buses = new List<BusDetails>{
                        new BusDetails(){ BusNumber="KA04-BA2041", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2042", ETA = BusDetails.GetETA()},
                        new BusDetails(){ BusNumber="KA04-BA2043", ETA = BusDetails.GetETA()}
                    } }
            };
        }
    }
}

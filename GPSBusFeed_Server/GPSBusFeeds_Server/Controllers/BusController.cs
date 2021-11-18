using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using GPSBusFeeds_Server.DataStorage;
using GPSBusFeeds_Server.HubConfig;
using GPSBusFeeds_Server.TimerFeatures;

namespace GPSBusFeeds_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private IHubContext<GPSHub> _hub; 

        public BusController(IHubContext<GPSHub> hub) 
        { 
            _hub = hub;
        }

        public IActionResult Get()
        { 
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transfergpsdata", DataManager.GetData())); 
            
            return Ok(new { Message = "Request Completed" }); 
        }
    }
}
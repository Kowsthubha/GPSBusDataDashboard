using Microsoft.AspNetCore.SignalR;
using GPSBusFeeds_Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GPSBusFeeds_Server.HubConfig
{
    public class GPSHub : Hub
    {
        public async Task BroadcastChartData(List<RouteModel> data) => await Clients.All.SendAsync("broadcastgpsdata", data);
    }
}

using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace BroadcastBackend.Hubs
{
    public class BroadcastHub : Hub
    {
        public async Task FromBroardcast(string message)
        {
            await this.Clients.All.SendAsync("FromBroardcast", $"FromBroardcast: {message}");
        }

        public async Task ToBroadcast(string message)
        {
            await FromBroardcast($"ToBroadcast: {message}");
        }
    }
}

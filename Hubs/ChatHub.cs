using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace FuzzySpin.Hubs
{
    public class ChatHub : Hub
    {

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            await Clients.Client(Context.ConnectionId).SendAsync("receive", "Connection Id : "+ Context.ConnectionId);
        }

        [HubMethodName("send")]
        public async Task SendMessage(string message)
        {
            await Clients.Others.SendAsync("receive", message);
        }

        
    }
}

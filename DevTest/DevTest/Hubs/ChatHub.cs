using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace DevTest.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.message(message);
        }

        public override Task OnConnected()
        {
            Clients.Client(Context.ConnectionId).hello();
            return base.OnConnected();
        }
    }
}
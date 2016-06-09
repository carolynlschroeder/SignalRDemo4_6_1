using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo4_6_1.Hubs
{
    public class SignalRDemoHub : Hub
    {
        public void LikeImage(string inputString)
        {
            //var retString = $"{userId} likes {imageId}";
            var retString = "Image has been clicked";
            Clients.All.addNewMessageToPage(retString);
        }
    }
}
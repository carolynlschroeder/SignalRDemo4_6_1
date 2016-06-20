using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalRDemo4_6_1.Entities;
using SignalRDemo4_6_1.Repositories;

namespace SignalRDemo4_6_1.Hubs
{
    public class SignalRDemoHub : Hub
    {
        public void LikeImage(string userId, Guid imageId)
        {
            var repository = new ImageRepository();
            var userLike = new UserLike
            {
                UserLikesId = Guid.NewGuid(),
                UserId = userId,
                ImageId = imageId
            };
            var image = repository.FindImageById(imageId);
            image.UserLikes.Add(userLike);
            repository.UpdateImage(image);
            Clients.All.addNewMessageToPage(userId, imageId);
        }
    }
}
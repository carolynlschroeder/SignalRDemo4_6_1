using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalRDemo4_6_1.Repositories;

namespace SignalRDemo4_6_1.BusinessLogic
{
    public class UIMethods
    {
        public static bool UserLikes(string userId, Guid imageId)
        {
            var repository = new ImageRepository();
            var userLikeList = repository.GetUserLikes();
            return userLikeList.Any(l => l.UserId == userId || l.ImageId == imageId);
        }

        public static int TotalLikes(Guid imageId)
        {
            var repository = new ImageRepository();
            var userLikeList = repository.GetUserLikes();
            return userLikeList.Count(l => l.ImageId == imageId);

        }
    }
}
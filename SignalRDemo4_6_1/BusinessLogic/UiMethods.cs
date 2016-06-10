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
            var image = repository.FindImageById(imageId);
            return image.UserLikes.Any(ui => ui.UserId == userId);

        }

        public static int TotalLikes(Guid imageId)
        {
            var repository = new ImageRepository();
            var image = repository.FindImageById(imageId);
            return image.UserLikes.Count();
        }
    }
}
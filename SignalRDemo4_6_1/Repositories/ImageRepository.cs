using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalRDemo4_6_1.Entities;

namespace SignalRDemo4_6_1.Repositories
{
    public class ImageRepository
    {
        private GalleryEntities entities = new GalleryEntities();

        public List<Image> GetImages()
        {
            return entities.Images.ToList();
        }

        public List<UserLike> GetUserLikes()
        {
            return entities.UserLikes.ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Image FindImageById(Guid imageId)
        {
            return entities.Images.FirstOrDefault(i => i.ImageId == imageId);
        }

        public void UpdateImage(Image image)
        {
            entities.Entry<Image>(image).State = EntityState.Modified;
            entities.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SignalRDemo4_6_1.Models;
using SignalRDemo4_6_1.Repositories;

namespace SignalRDemo4_6_1.Controllers
{
    [Authorize]
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            var repository = new ImageRepository();
            var model = repository.GetImages().Select(i => new ImageModel
            {
                ImageId = i.ImageId,
                ImageName = i.ImageName
            }).ToList();
            return View(model);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDemo4_6_1.Models
{
    public class UserLikesModel
    {
        public Guid UserLikesUd { get; set; }
        public Guid UserId { get; set; }
        public Guid ImageId { get; set; }
    }
}
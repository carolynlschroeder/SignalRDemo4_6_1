//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignalRDemo4_6_1.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLike
    {
        public System.Guid UserLikesId { get; set; }
        public string UserId { get; set; }
        public System.Guid ImageId { get; set; }
    
        public virtual Image Image { get; set; }
    }
}

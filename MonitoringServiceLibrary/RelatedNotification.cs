//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringServiceLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class RelatedNotification
    {
        public int RelationId { get; set; }
        public int NotificationIdParent { get; set; }
        public int NotificationIdChild { get; set; }
    
        public virtual NotificationItem NotificationItem { get; set; }
        public virtual NotificationItem NotificationItem1 { get; set; }
    }
}

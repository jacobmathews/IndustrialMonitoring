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
    
    public partial class FanCoilBot
    {
        public int BotProcessId { get; set; }
        public Nullable<int> ChatId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public bool IsAuthorized { get; set; }
    
        public virtual User User { get; set; }
    }
}

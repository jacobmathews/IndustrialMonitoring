//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringServiceLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public Item()
        {
            this.ItemsLogs = new HashSet<ItemsLog>();
            this.ItemsLogLatests = new HashSet<ItemsLogLatest>();
            this.TabsItems = new HashSet<TabsItem>();
            this.UsersItemsPermissions = new HashSet<UsersItemsPermission>();
        }
    
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemType { get; set; }
        public string Location { get; set; }
        public int SaveInItemsLogTimeInterval { get; set; }
        public int SaveInItemsLogLastesTimeInterval { get; set; }
        public int ShowInUITimeInterval { get; set; }
        public int ScanCycle { get; set; }
        public int SaveInItemsLogWhen { get; set; }
        public int SaveInItemsLogLastWhen { get; set; }
    
        public virtual ICollection<ItemsLog> ItemsLogs { get; set; }
        public virtual ICollection<ItemsLogLatest> ItemsLogLatests { get; set; }
        public virtual ICollection<TabsItem> TabsItems { get; set; }
        public virtual ICollection<UsersItemsPermission> UsersItemsPermissions { get; set; }
    }
}
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
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.ItemsLogs = new HashSet<ItemsLog>();
            this.ItemsLogLatests = new HashSet<ItemsLogLatest>();
            this.ItemsLogRawDatas = new HashSet<ItemsLogRawData>();
            this.LogOutliers = new HashSet<LogOutlier>();
            this.NotificationItems = new HashSet<NotificationItem>();
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
        public Nullable<int> DefinationType { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Order { get; set; }
        public string BACnetIP { get; set; }
        public Nullable<int> BACnetPort { get; set; }
        public Nullable<int> BACnetControllerInstance { get; set; }
        public Nullable<int> BACnetItemInstance { get; set; }
        public Nullable<int> BACnetItemType { get; set; }
        public string MinRange { get; set; }
        public string MaxRange { get; set; }
        public Nullable<bool> NormalizeWhenOutOfRange { get; set; }
        public Nullable<int> ThreadGroupId { get; set; }
        public Nullable<int> NumberOfDataForBoxplot { get; set; }
        public Nullable<int> InOut { get; set; }
    
        public virtual ThreadGroup ThreadGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsLog> ItemsLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsLogLatest> ItemsLogLatests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsLogRawData> ItemsLogRawDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogOutlier> LogOutliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationItem> NotificationItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabsItem> TabsItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersItemsPermission> UsersItemsPermissions { get; set; }
    }
}

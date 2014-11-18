﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndustrialMonitoring.NotificationServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Notification1", Namespace="http://schemas.datacontract.org/2004/07/MonitoringServiceLibrary.ViewModels")]
    [System.SerializableAttribute()]
    public partial class Notification1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NotificationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotificationMsgField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((this.ItemIdField.Equals(value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NotificationId {
            get {
                return this.NotificationIdField;
            }
            set {
                if ((this.NotificationIdField.Equals(value) != true)) {
                    this.NotificationIdField = value;
                    this.RaisePropertyChanged("NotificationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NotificationMsg {
            get {
                return this.NotificationMsgField;
            }
            set {
                if ((object.ReferenceEquals(this.NotificationMsgField, value) != true)) {
                    this.NotificationMsgField = value;
                    this.RaisePropertyChanged("NotificationMsg");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NotificationServiceReference.INotificationService")]
    public interface INotificationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/HasNotification", ReplyAction="http://tempuri.org/INotificationService/HasNotificationResponse")]
        bool HasNotification(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/HasNotification", ReplyAction="http://tempuri.org/INotificationService/HasNotificationResponse")]
        System.Threading.Tasks.Task<bool> HasNotificationAsync(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/GetNotifications", ReplyAction="http://tempuri.org/INotificationService/GetNotificationsResponse")]
        System.Collections.Generic.List<IndustrialMonitoring.NotificationServiceReference.Notification1> GetNotifications(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/GetNotifications", ReplyAction="http://tempuri.org/INotificationService/GetNotificationsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<IndustrialMonitoring.NotificationServiceReference.Notification1>> GetNotificationsAsync(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/SystemHasNotification", ReplyAction="http://tempuri.org/INotificationService/SystemHasNotificationResponse")]
        bool SystemHasNotification(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/SystemHasNotification", ReplyAction="http://tempuri.org/INotificationService/SystemHasNotificationResponse")]
        System.Threading.Tasks.Task<bool> SystemHasNotificationAsync(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INotificationServiceChannel : IndustrialMonitoring.NotificationServiceReference.INotificationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotificationServiceClient : System.ServiceModel.ClientBase<IndustrialMonitoring.NotificationServiceReference.INotificationService>, IndustrialMonitoring.NotificationServiceReference.INotificationService {
        
        public NotificationServiceClient() {
        }
        
        public NotificationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NotificationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool HasNotification(int itemId) {
            return base.Channel.HasNotification(itemId);
        }
        
        public System.Threading.Tasks.Task<bool> HasNotificationAsync(int itemId) {
            return base.Channel.HasNotificationAsync(itemId);
        }
        
        public System.Collections.Generic.List<IndustrialMonitoring.NotificationServiceReference.Notification1> GetNotifications(int itemId) {
            return base.Channel.GetNotifications(itemId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<IndustrialMonitoring.NotificationServiceReference.Notification1>> GetNotificationsAsync(int itemId) {
            return base.Channel.GetNotificationsAsync(itemId);
        }
        
        public bool SystemHasNotification(int userId) {
            return base.Channel.SystemHasNotification(userId);
        }
        
        public System.Threading.Tasks.Task<bool> SystemHasNotificationAsync(int userId) {
            return base.Channel.SystemHasNotificationAsync(userId);
        }
    }
}

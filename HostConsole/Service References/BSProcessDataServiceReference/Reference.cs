﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostConsole.BSProcessDataServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BSProcessDataServiceReference.IProcessDataService")]
    public interface IProcessDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessDataService/GetPreHeatingZoneTemperature", ReplyAction="http://tempuri.org/IProcessDataService/GetPreHeatingZoneTemperatureResponse")]
        double GetPreHeatingZoneTemperature();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessDataService/GetPreHeatingZoneTemperature", ReplyAction="http://tempuri.org/IProcessDataService/GetPreHeatingZoneTemperatureResponse")]
        System.Threading.Tasks.Task<double> GetPreHeatingZoneTemperatureAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessDataService/GetSterilizerZoneTemperature", ReplyAction="http://tempuri.org/IProcessDataService/GetSterilizerZoneTemperatureResponse")]
        double GetSterilizerZoneTemperature();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessDataService/GetSterilizerZoneTemperature", ReplyAction="http://tempuri.org/IProcessDataService/GetSterilizerZoneTemperatureResponse")]
        System.Threading.Tasks.Task<double> GetSterilizerZoneTemperatureAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessDataService/GetCoolingZoneTemperature", ReplyAction="http://tempuri.org/IProcessDataService/GetCoolingZoneTemperatureResponse")]
        double GetCoolingZoneTemperature();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProcessDataService/GetCoolingZoneTemperature", ReplyAction="http://tempuri.org/IProcessDataService/GetCoolingZoneTemperatureResponse")]
        System.Threading.Tasks.Task<double> GetCoolingZoneTemperatureAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProcessDataServiceChannel : HostConsole.BSProcessDataServiceReference.IProcessDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProcessDataServiceClient : System.ServiceModel.ClientBase<HostConsole.BSProcessDataServiceReference.IProcessDataService>, HostConsole.BSProcessDataServiceReference.IProcessDataService {
        
        public ProcessDataServiceClient() {
        }
        
        public ProcessDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProcessDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProcessDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProcessDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetPreHeatingZoneTemperature() {
            return base.Channel.GetPreHeatingZoneTemperature();
        }
        
        public System.Threading.Tasks.Task<double> GetPreHeatingZoneTemperatureAsync() {
            return base.Channel.GetPreHeatingZoneTemperatureAsync();
        }
        
        public double GetSterilizerZoneTemperature() {
            return base.Channel.GetSterilizerZoneTemperature();
        }
        
        public System.Threading.Tasks.Task<double> GetSterilizerZoneTemperatureAsync() {
            return base.Channel.GetSterilizerZoneTemperatureAsync();
        }
        
        public double GetCoolingZoneTemperature() {
            return base.Channel.GetCoolingZoneTemperature();
        }
        
        public System.Threading.Tasks.Task<double> GetCoolingZoneTemperatureAsync() {
            return base.Channel.GetCoolingZoneTemperatureAsync();
        }
    }
}
